#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Object
struct Object_t1021602117;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// LevelManager
struct  LevelManager_t3355282079  : public MonoBehaviour_t1158329972
{
public:
	// System.Single LevelManager::autoLoadNextLevelAfter
	float ___autoLoadNextLevelAfter_2;
	// UnityEngine.Object LevelManager::startScene
	Object_t1021602117 * ___startScene_3;
	// UnityEngine.Object LevelManager::finalScene
	Object_t1021602117 * ___finalScene_4;

public:
	inline static int32_t get_offset_of_autoLoadNextLevelAfter_2() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___autoLoadNextLevelAfter_2)); }
	inline float get_autoLoadNextLevelAfter_2() const { return ___autoLoadNextLevelAfter_2; }
	inline float* get_address_of_autoLoadNextLevelAfter_2() { return &___autoLoadNextLevelAfter_2; }
	inline void set_autoLoadNextLevelAfter_2(float value)
	{
		___autoLoadNextLevelAfter_2 = value;
	}

	inline static int32_t get_offset_of_startScene_3() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___startScene_3)); }
	inline Object_t1021602117 * get_startScene_3() const { return ___startScene_3; }
	inline Object_t1021602117 ** get_address_of_startScene_3() { return &___startScene_3; }
	inline void set_startScene_3(Object_t1021602117 * value)
	{
		___startScene_3 = value;
		Il2CppCodeGenWriteBarrier(&___startScene_3, value);
	}

	inline static int32_t get_offset_of_finalScene_4() { return static_cast<int32_t>(offsetof(LevelManager_t3355282079, ___finalScene_4)); }
	inline Object_t1021602117 * get_finalScene_4() const { return ___finalScene_4; }
	inline Object_t1021602117 ** get_address_of_finalScene_4() { return &___finalScene_4; }
	inline void set_finalScene_4(Object_t1021602117 * value)
	{
		___finalScene_4 = value;
		Il2CppCodeGenWriteBarrier(&___finalScene_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
