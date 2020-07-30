﻿using System.Collections.Generic;
using System.Linq;
using MapGeneration.Core.LayoutEvolvers.SimulatedAnnealing;
using MapGeneration.Core.LayoutGenerators.DungeonGenerator;
using MapGeneration.MetaOptimization;
using MapGeneration.MetaOptimization.Configurations;
using MapGeneration.MetaOptimization.Evolution;
using MapGeneration.MetaOptimization.Evolution.DungeonGeneratorEvolution;
using MapGeneration.MetaOptimization.Mutations;
using MapGeneration.MetaOptimization.Mutations.MaxBranching;
using MapGeneration.MetaOptimization.Mutations.MaxIterations;
using MapGeneration.MetaOptimization.Stats;
using MapGeneration.Utils.Interfaces;
using SandboxEvolutionRunner.Evolution;
using SandboxEvolutionRunner.Utils;

namespace SandboxEvolutionRunner.Scenarios
{
    public class MaxBranchingScenario : EvolutionScenario
    {
        protected override DungeonGeneratorConfiguration<int> GetInitialConfiguration(NamedMapDescription namedMapDescription)
        {
            var configuration = GetBasicConfiguration(namedMapDescription);
            configuration.SimulatedAnnealingConfiguration = new SimulatedAnnealingConfigurationProvider(new SimulatedAnnealingConfiguration()
            {
                MaxIterationsWithoutSuccess = 100,
            });

            return configuration;
        }

        protected override List<IPerformanceAnalyzer<DungeonGeneratorConfiguration<int>, Individual<int>>> GetAnalyzers(Input input)
        {
            return new List<IPerformanceAnalyzer<DungeonGeneratorConfiguration<int>, Individual<int>>>()
            {
                new TestAnalyzer<DungeonGeneratorConfiguration<int>, GeneratorData>(),
            };
        }

        private class TestAnalyzer<TConfiguration, TGeneratorStats> : MaxBranchingAnalyzer<TConfiguration, TGeneratorStats>, IPerformanceAnalyzer<TConfiguration, Individual<TConfiguration, IGeneratorEvaluation<TGeneratorStats>>>
            where TConfiguration : ISimulatedAnnealingConfiguration, ISmartCloneable<TConfiguration>
            where TGeneratorStats : IChainsStats
        {
            public new List<IMutation<TConfiguration>> ProposeMutations(Individual<TConfiguration, IGeneratorEvaluation<TGeneratorStats>> individual)
            {
                var mutations = new List<IMutation<TConfiguration>>();

                // Do not apply this mutation multiple times
                if (individual.Mutations.All(x => x.GetType() != typeof(MaxBranchingMutation<TConfiguration>)))
                {
                    mutations.Add(new MaxBranchingMutation<TConfiguration>(5, 4));
                    mutations.Add(new MaxBranchingMutation<TConfiguration>(5, 3));
                    mutations.Add(new MaxBranchingMutation<TConfiguration>(5, 2));
                }

                return mutations;
            }
        }
    }
}