﻿using HarmonyLib;

namespace DeluxeJournal.Patching
{
    /// <summary>A set of Harmony patches.</summary>
    internal interface IPatch
    {
        /// <summary>The name of this instance.</summary>
        string Name { get; }

        /// <summary>Apply Harmony patches.</summary>
        /// <param name="harmony">Harmony instance.</param>
        void Apply(Harmony harmony);
    }
}
