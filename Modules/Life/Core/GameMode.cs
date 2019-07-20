// Copyright (c) 2019 Valentin LAMOTHE (MIT LICENSE)
using System;
using UnityEngine;

namespace Life.Core
{
    using UnityEngine;

    public class Gamemode : MonoBehaviour
    {
        /// <summary>
        /// Called when a player connect
        /// </summary>
        /// <param name="playerId">The netId of the connected player</param>
        public virtual void OnPlayerConnect(uint playerId) { }
        /// <summary>
        /// Called when a player disconnect
        /// </summary>
        /// <param name="playerId">The netId of the disconnected player</param>
        public virtual void OnPlayerDisconnect(uint playerId) { }
        /// <summary>
        /// Called when a player spawn
        /// </summary>
        /// <param name="playerId">The netId of the spawned player</param>
        public virtual void OnPlayerSpawn(uint playerId) { }

        /// <summary>
        /// Called when a vehicle respawns
        /// </summary>
        /// <param name="vehicleId">The netId of the vehicle</param>
        public virtual void OnVehicleSpawn(uint vehicleId) { }
        /// <summary>
        /// Called when a vehicle is destroyed - either by exploding or becoming submerged in water.
        /// </summary>
        /// <param name="vehicleId">The netId of the vehicle</param>
        public virtual void OnVehicleDeath(uint vehicleId) { }
    }

}
