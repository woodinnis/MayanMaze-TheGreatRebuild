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

// Arrow
struct Arrow_t3589335331;
// UnityEngine.Collider2D
struct Collider2D_t646061738;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_Collider2D646061738.h"
#include "UnityEngine_UnityEngine_Vector22243707579.h"

// System.Void Arrow::.ctor()
extern "C"  void Arrow__ctor_m2571922996 (Arrow_t3589335331 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Arrow::Start()
extern "C"  void Arrow_Start_m3865675240 (Arrow_t3589335331 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Arrow::OnTriggerEnter2D(UnityEngine.Collider2D)
extern "C"  void Arrow_OnTriggerEnter2D_m3385373376 (Arrow_t3589335331 * __this, Collider2D_t646061738 * ___collider0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void Arrow::OnMouseDrag()
extern "C"  void Arrow_OnMouseDrag_m43074162 (Arrow_t3589335331 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector2 Arrow::CalculateWorldPointOfMouseClick()
extern "C"  Vector2_t2243707579  Arrow_CalculateWorldPointOfMouseClick_m198866089 (Arrow_t3589335331 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector2 Arrow::SnapToGrid(UnityEngine.Vector2)
extern "C"  Vector2_t2243707579  Arrow_SnapToGrid_m4065121554 (Arrow_t3589335331 * __this, Vector2_t2243707579  ___rawWorldPos0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
