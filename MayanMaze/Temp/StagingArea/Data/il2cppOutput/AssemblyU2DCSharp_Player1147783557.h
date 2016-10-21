#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Transform
struct Transform_t3275118058;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "AssemblyU2DCSharp_Player_Direction264951747.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Player
struct  Player_t1147783557  : public MonoBehaviour_t1158329972
{
public:
	// System.Single Player::playerMoveSpeed
	float ___playerMoveSpeed_2;
	// Player/Direction Player::playerDirection
	int32_t ___playerDirection_3;
	// UnityEngine.Transform Player::transform
	Transform_t3275118058 * ___transform_4;
	// System.Boolean Player::isMovingTowards
	bool ___isMovingTowards_5;

public:
	inline static int32_t get_offset_of_playerMoveSpeed_2() { return static_cast<int32_t>(offsetof(Player_t1147783557, ___playerMoveSpeed_2)); }
	inline float get_playerMoveSpeed_2() const { return ___playerMoveSpeed_2; }
	inline float* get_address_of_playerMoveSpeed_2() { return &___playerMoveSpeed_2; }
	inline void set_playerMoveSpeed_2(float value)
	{
		___playerMoveSpeed_2 = value;
	}

	inline static int32_t get_offset_of_playerDirection_3() { return static_cast<int32_t>(offsetof(Player_t1147783557, ___playerDirection_3)); }
	inline int32_t get_playerDirection_3() const { return ___playerDirection_3; }
	inline int32_t* get_address_of_playerDirection_3() { return &___playerDirection_3; }
	inline void set_playerDirection_3(int32_t value)
	{
		___playerDirection_3 = value;
	}

	inline static int32_t get_offset_of_transform_4() { return static_cast<int32_t>(offsetof(Player_t1147783557, ___transform_4)); }
	inline Transform_t3275118058 * get_transform_4() const { return ___transform_4; }
	inline Transform_t3275118058 ** get_address_of_transform_4() { return &___transform_4; }
	inline void set_transform_4(Transform_t3275118058 * value)
	{
		___transform_4 = value;
		Il2CppCodeGenWriteBarrier(&___transform_4, value);
	}

	inline static int32_t get_offset_of_isMovingTowards_5() { return static_cast<int32_t>(offsetof(Player_t1147783557, ___isMovingTowards_5)); }
	inline bool get_isMovingTowards_5() const { return ___isMovingTowards_5; }
	inline bool* get_address_of_isMovingTowards_5() { return &___isMovingTowards_5; }
	inline void set_isMovingTowards_5(bool value)
	{
		___isMovingTowards_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
