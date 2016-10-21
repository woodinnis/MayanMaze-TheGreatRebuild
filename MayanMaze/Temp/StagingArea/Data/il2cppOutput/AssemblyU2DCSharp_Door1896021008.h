#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// Player
struct Player_t1147783557;
// UnityEngine.Transform
struct Transform_t3275118058;
// LevelManager
struct LevelManager_t3355282079;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Door
struct  Door_t1896021008  : public MonoBehaviour_t1158329972
{
public:
	// Player Door::player
	Player_t1147783557 * ___player_2;
	// UnityEngine.Transform Door::transform
	Transform_t3275118058 * ___transform_3;
	// LevelManager Door::levelManager
	LevelManager_t3355282079 * ___levelManager_4;

public:
	inline static int32_t get_offset_of_player_2() { return static_cast<int32_t>(offsetof(Door_t1896021008, ___player_2)); }
	inline Player_t1147783557 * get_player_2() const { return ___player_2; }
	inline Player_t1147783557 ** get_address_of_player_2() { return &___player_2; }
	inline void set_player_2(Player_t1147783557 * value)
	{
		___player_2 = value;
		Il2CppCodeGenWriteBarrier(&___player_2, value);
	}

	inline static int32_t get_offset_of_transform_3() { return static_cast<int32_t>(offsetof(Door_t1896021008, ___transform_3)); }
	inline Transform_t3275118058 * get_transform_3() const { return ___transform_3; }
	inline Transform_t3275118058 ** get_address_of_transform_3() { return &___transform_3; }
	inline void set_transform_3(Transform_t3275118058 * value)
	{
		___transform_3 = value;
		Il2CppCodeGenWriteBarrier(&___transform_3, value);
	}

	inline static int32_t get_offset_of_levelManager_4() { return static_cast<int32_t>(offsetof(Door_t1896021008, ___levelManager_4)); }
	inline LevelManager_t3355282079 * get_levelManager_4() const { return ___levelManager_4; }
	inline LevelManager_t3355282079 ** get_address_of_levelManager_4() { return &___levelManager_4; }
	inline void set_levelManager_4(LevelManager_t3355282079 * value)
	{
		___levelManager_4 = value;
		Il2CppCodeGenWriteBarrier(&___levelManager_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
