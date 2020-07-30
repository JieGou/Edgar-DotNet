﻿using System.Collections.Generic;
using MapGeneration.Benchmarks;

namespace MapGeneration.MetaOptimization.Stats
{
    public class GeneratorStats
    {
        public List<ChainStats> ChainsStats { get; }

        public List<GeneratorRun> GeneratorRuns { get; }

        public GeneratorStats(List<ChainStats> chainsStats, List<GeneratorRun> generatorRuns)
        {
            ChainsStats = chainsStats;
            GeneratorRuns = generatorRuns;
        }

        public GeneratorStats(List<ChainStats> chainsStats, GeneratorRun generatorRun)
        {
            ChainsStats = chainsStats;
            GeneratorRuns = new List<GeneratorRun>() { generatorRun };
        }
    }
}