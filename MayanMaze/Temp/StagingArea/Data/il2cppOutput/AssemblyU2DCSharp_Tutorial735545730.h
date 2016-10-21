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
// LevelManager
struct LevelManager_t3355282079;
// UnityEngine.UI.Text
struct Text_t356221433;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Tutorial
struct  Tutorial_t735545730  : public MonoBehaviour_t1158329972
{
public:
	// System.String[] Tutorial::checkLevels
	StringU5BU5D_t1642385972* ___checkLevels_2;
	// System.String[] Tutorial::tutorialMessages
	StringU5BU5D_t1642385972* ___tutorialMessages_3;
	// LevelManager Tutorial::levelManager
	LevelManager_t3355282079 * ___levelManager_4;
	// UnityEngine.UI.Text Tutorial::text
	Text_t356221433 * ___text_5;

public:
	inline static int32_t get_offset_of_checkLevels_2() { return static_cast<int32_t>(offsetof(Tutorial_t735545730, ___checkLevels_2)); }
	inline StringU5BU5D_t1642385972* get_checkLevels_2() const { return ___checkLevels_2; }
	inline StringU5BU5D_t1642385972** get_address_of_checkLevels_2() { return &___checkLevels_2; }
	inline void set_checkLevels_2(StringU5BU5D_t1642385972* value)
	{
		___checkLevels_2 = value;
		Il2CppCodeGenWriteBarrier(&___checkLevels_2, value);
	}

	inline static int32_t get_offset_of_tutorialMessages_3() { return static_cast<int32_t>(offsetof(Tutorial_t735545730, ___tutorialMessages_3)); }
	inline StringU5BU5D_t1642385972* get_tutorialMessages_3() const { return ___tutorialMessages_3; }
	inline StringU5BU5D_t1642385972** get_address_of_tutorialMessages_3() { return &___tutorialMessages_3; }
	inline void set_tutorialMessages_3(StringU5BU5D_t1642385972* value)
	{
		___tutorialMessages_3 = value;
		Il2CppCodeGenWriteBarrier(&___tutorialMessages_3, value);
	}

	inline static int32_t get_offset_of_levelManager_4() { return static_cast<int32_t>(offsetof(Tutorial_t735545730, ___levelManager_4)); }
	inline LevelManager_t3355282079 * get_levelManager_4() const { return ___levelManager_4; }
	inline LevelManager_t3355282079 ** get_address_of_levelManager_4() { return &___levelManager_4; }
	inline void set_levelManager_4(LevelManager_t3355282079 * value)
	{
		___levelManager_4 = value;
		Il2CppCodeGenWriteBarrier(&___levelManager_4, value);
	}

	inline static int32_t get_offset_of_text_5() { return static_cast<int32_t>(offsetof(Tutorial_t735545730, ___text_5)); }
	inline Text_t356221433 * get_text_5() const { return ___text_5; }
	inline Text_t356221433 ** get_address_of_text_5() { return &___text_5; }
	inline void set_text_5(Text_t356221433 * value)
	{
		___text_5 = value;
		Il2CppCodeGenWriteBarrier(&___text_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
