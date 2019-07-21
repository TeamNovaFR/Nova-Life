// Copyright (c) 2019 Valentin LAMOTHE (MIT LICENSE)
using System;
using UnityEngine;

namespace Life.Core
{
    public class Gamemode : MonoBehaviour
    {

        #region Callbacks
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
        #endregion

        #region Methods
        
        /// <summary>
        /// Create a static vehicle
        /// </summary>
        /// <param name="modelId">The modelId of the vehicle</param>
        /// <param name="pos">The position of spawned vehicle</param>
        /// <param name="rot">The rotation of spawned vehicle</param>
        /// <param name="color1">The primary color of spawned vehicle</param>
        /// <param name="color2">The secondary color of spawned vehicle</param>
        public virtual void AddStaticVehicle(int modelId, Vector3 pos, Vector3 rot, string color1, string color2) { }

        /// <summary>
        /// Create a static vehicle with custom respawn time
        /// </summary>
        /// <param name="modelId">The modelId of the vehicle</param>
        /// <param name="pos">The position of spawned vehicle</param>
        /// <param name="rot">The rotation of spawned vehicle</param>
        /// <param name="color1">The primary color of spawned vehicle</param>
        /// <param name="color2">The secondary color of spawned vehicle</param>
        public virtual void AddStaticVehicleEx(int modelId, Vector3 pos, Vector3 rot, string color1, string color2, float respawnTime) { }

        #endregion
        
    }

}