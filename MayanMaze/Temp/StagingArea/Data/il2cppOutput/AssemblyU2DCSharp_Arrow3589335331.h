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
// UnityEngine.Camera
struct Camera_t189460977;
// System.Collections.Generic.Dictionary`2<System.String,System.Int32>
struct Dictionary_2_t3986656710;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Arrow
struct  Arrow_t3589335331  : public MonoBehaviour_t1158329972
{
public:
	// Player Arrow::player
	Player_t1147783557 * ___player_2;
	// UnityEngine.Transform Arrow::transform
	Transform_t3275118058 * ___transform_3;
	// UnityEngine.Camera Arrow::myCamera
	Camera_t189460977 * ___myCamera_4;

public:
	inline static int32_t get_offset_of_player_2() { return static_cast<int32_t>(offsetof(Arrow_t3589335331, ___player_2)); }
	inline Player_t1147783557 * get_player_2() const { return ___player_2; }
	inline Player_t1147783557 ** get_address_of_player_2() { return &___player_2; }
	inline void set_player_2(Player_t1147783557 * value)
	{
		___player_2 = value;
		Il2CppCodeGenWriteBarrier(&___player_2, value);
	}

	inline static int32_t get_offset_of_transform_3() { return static_cast<int32_t>(offsetof(Arrow_t3589335331, ___transform_3)); }
	inline Transform_t3275118058 * get_transform_3() const { return ___transform_3; }
	inline Transform_t3275118058 ** get_address_of_transform_3() { return &___transform_3; }
	inline void set_transform_3(Transform_t3275118058 * value)
	{
		___transform_3 = value;
		Il2CppCodeGenWriteBarrier(&___transform_3, value);
	}

	inline static int32_t get_offset_of_myCamera_4() { return static_cast<int32_t>(offsetof(Arrow_t3589335331, ___myCamera_4)); }
	inline Camera_t189460977 * get_myCamera_4() const { return ___myCamera_4; }
	inline Camera_t189460977 ** get_address_of_myCamera_4() { return &___myCamera_4; }
	inline void set_myCamera_4(Camera_t189460977 * value)
	{
		___myCamera_4 = value;
		Il2CppCodeGenWriteBarrier(&___myCamera_4, value);
	}
};

struct Arrow_t3589335331_StaticFields
{
public:
	// System.Collections.Generic.Dictionary`2<System.String,System.Int32> Arrow::<>f__switch$map0
	Dictionary_2_t3986656710 * ___U3CU3Ef__switchU24map0_5;

public:
	inline static int32_t get_offset_of_U3CU3Ef__switchU24map0_5() { return static_cast<int32_t>(offsetof(Arrow_t3589335331_StaticFields, ___U3CU3Ef__switchU24map0_5)); }
	inline Dictionary_2_t3986656710 * get_U3CU3Ef__switchU24map0_5() const { return ___U3CU3Ef__switchU24map0_5; }
	inline Dictionary_2_t3986656710 ** get_address_of_U3CU3Ef__switchU24map0_5() { return &___U3CU3Ef__switchU24map0_5; }
	inline void set_U3CU3Ef__switchU24map0_5(Dictionary_2_t3986656710 * value)
	{
		___U3CU3Ef__switchU24map0_5 = value;
		Il2CppCodeGenWriteBarrier(&___U3CU3Ef__switchU24map0_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
