using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Data", menuName = "Crear Enemy Data")]
public class EnemyData : ScriptableObject
{
    [Header("PARAMETROS PARA EL PLAYER")]
    [Tooltip("DA�O DEL PLAYER")]
    public float playerdamage = 25f;

    [Header("PARAMETROS PARA SEGUIR AL PLAYER")]
    [Tooltip("DISTANCIA PARA DETENERSE")]
    public float Distance;
    [Tooltip("VELOCIDAD DE ROTACION")]
    public float SpeedRotation;
    [Tooltip("DISTANCIA PARA DETENERSE")]
    public float stopDistance;

    [Header("PARAMETROS PARA ATACAR AL PLAYER")]
    [Tooltip("RANGO DE ATAQUE")]
    public float attackRange;
    [Tooltip("RANGO DE VISTA")]
    public float sightRange;

    [Header("PARAMETROS DE DISPARO SPIDER")]
    [Tooltip("DA�O")]
    [SerializeField] public float damage = 25f;
    [Tooltip("TIEMPO ENTRE DISPAROS")]
    public float ShootLoop;
    [Tooltip("DISTANCIA PARA EMPEZAR A DISPARAR")]
    public float shootDistance;
    [Tooltip("VELOCIDAD BALA")]
    public float speed = 100;
    [Tooltip("VELOCIDAD ROTACION TORRETA")]
    public float SpeedRotate;

    [Header("PARAMETROS DE DISPARO TORRETAS")]
    [Tooltip("DA�O")]
    [SerializeField]
    public float turretdamage = 25f;
    [Tooltip("TIEMPO ENTRE DISPAROS")]
    public float turretShootLoop;
    [Tooltip("DISTANCIA PARA EMPEZAR A DISPARAR")]
    public float turretshootDistance;
    [Tooltip("VELOCIDAD BALA")]
    public float turretspeed = 100;
    [Tooltip("VELOCIDAD ROTACION")]
    public float turretSpeedRotate;
}
