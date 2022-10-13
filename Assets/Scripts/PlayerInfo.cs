using UnityEngine;
using Unity.Netcode;
using UnityEngine.Serialization;
using Unity.Collections;

public struct PlayerInfo : INetworkSerializable, System.IEquatable<PlayerInfo> {
    public ulong clientId;
    public Color color;

    public PlayerInfo(ulong id, Color c, bool isReady=false) {
        clientId = id;
        color = c;
        isReady = ready;
    }

    public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter {
        serializer.SerializeValue(ref clientId);
        serializer.SerializeValue(ref color);
        serializer.SerializeValue(ref isReady);
    }

   
}