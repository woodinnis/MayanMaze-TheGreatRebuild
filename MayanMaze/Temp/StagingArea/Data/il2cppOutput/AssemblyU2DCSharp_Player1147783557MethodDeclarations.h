#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// Player
struct Player_t1147783557;
// UnityEngine.Collision2D
struct Collision2D_t1539500754;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_Collision2D1539500754.h"
#include "UnityEngine_UnityEngine_Vector22243707579.h"

// System.Void Player::.ctor()
extern "C"  void Player__ctor_m1986401168 (Player_t1147783557 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Player::Start()
extern "C"  void Player_Start_m3139373552 (Player_t1147783557 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Player::FixedUpdate()
extern "C"  void Player_FixedUpdate_m252956515 (Player_t1147783557 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Player::OnCollisionEnter2D(UnityEngine.Collision2D)
extern "C"  void Player_OnCollisionEnter2D_m2184870686 (Player_t1147783557 * __this, Collision2D_t1539500754 * ___collision0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Player::ChangePlayerDirection()
extern "C"  void Player_ChangePlayerDirection_m430343710 (Player_t1147783557 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Player::OnCollisionExit2D()
extern "C"  void Player_OnCollisionExit2D_m842635869 (Player_t1147783557 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector2 Player::SnapToGrid(UnityEngine.Vector2)
extern "C"  Vector2_t2243707579  Player_SnapToGrid_m3372292812 (Player_t1147783557 * __this, Vector2_t2243707579  ___rawWorldPos0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
