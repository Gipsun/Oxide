﻿using Oxide.Core.Libraries.Covalence;

namespace Oxide.Game.SpaceEngineers.Libraries.Covalence
{
    /// <summary>
    /// Provides Covalence functionality for the game "Space Engineers"
    /// </summary>
    public class SpaceEngineersCovalenceProvider : ICovalenceProvider
    {
        /// <summary>
        /// Gets the name of the game for which this provider provides
        /// </summary>
        public string GameName => "SpaceEngineers";

        /// <summary>
        /// Gets the singleton instance of this provider
        /// </summary>
        internal static SpaceEngineersCovalenceProvider Instance { get; private set; }

        public SpaceEngineersCovalenceProvider()
        {
            Instance = this;
        }

        /// <summary>
        /// Gets the player manager
        /// </summary>
        public SpaceEngineersPlayerManager PlayerManager { get; private set; }

        /// <summary>
        /// Gets the command system provider
        /// </summary>
        public SpaceEngineersCommandSystem CommandSystem { get; private set; }

        /// <summary>
        /// Creates the game-specific server object
        /// </summary>
        /// <returns></returns>
        public IServer CreateServer() => new SpaceEngineersServer();

        /// <summary>
        /// Creates the game-specific player manager object
        /// </summary>
        /// <returns></returns>
        public IPlayerManager CreatePlayerManager() => PlayerManager = new SpaceEngineersPlayerManager();

        /// <summary>
        /// Creates the game-specific command system provider object
        /// </summary>
        /// <returns></returns>
        public ICommandSystem CreateCommandSystemProvider() => CommandSystem = new SpaceEngineersCommandSystem();
    }
}
