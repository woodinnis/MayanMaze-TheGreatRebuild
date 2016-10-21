#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// System.String[]
struct StringU5BU5D_t1642385972;
// UnityEngine.UI.Text
struct Text_t356221433;
// LevelManager
struct LevelManager_t3355282079;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// LevelNumber
struct  LevelNumber_t62551759  : public MonoBehaviour_t1158329972
{
public:
	// System.String[] LevelNumber::levels
	StringU5BU5D_t1642385972* ___levels_2;
	// UnityEngine.UI.Text LevelNumber::text
	Text_t356221433 * ___text_3;
	// LevelManager LevelNumber::levelManager
	LevelManager_t3355282079 * ___levelManager_4;

public:
	inline static int32_t get_offset_of_levels_2() { return static_cast<int32_t>(offsetof(LevelNumber_t62551759, ___levels_2)); }
	inline StringU5BU5D_t1642385972* get_levels_2() const { return ___levels_2; }
	inline StringU5BU5D_t1642385972** get_address_of_levels_2() { return &___levels_2; }
	inline void set_levels_2(StringU5BU5D_t1642385972* value)
	{
		___levels_2 = value;
		Il2CppCodeGenWriteBarrier(&___levels_2, value);
	}

	inline static int32_t get_offset_of_text_3() { return static_cast<int32_t>(offsetof(LevelNumber_t62551759, ___text_3)); }
	inline Text_t356221433 * get_text_3() const { return ___text_3; }
	inline Text_t356221433 ** get_address_of_text_3() { return &___text_3; }
	inline void set_text_3(Text_t356221433 * value)
	{
		___text_3 = value;
		Il2CppCodeGenWriteBarrier(&___text_3, value);
	}

	inline static int32_t get_offset_of_levelManager_4() { return static_cast<int32_t>(offsetof(LevelNumber_t62551759, ___levelManager_4)); }
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
