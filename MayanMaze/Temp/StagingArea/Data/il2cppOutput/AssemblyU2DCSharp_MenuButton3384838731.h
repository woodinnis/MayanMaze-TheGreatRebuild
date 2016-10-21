#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.UI.Button
struct Button_t2872111280;
// LevelManager
struct LevelManager_t3355282079;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MenuButton
struct  MenuButton_t3384838731  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Button MenuButton::button
	Button_t2872111280 * ___button_2;
	// LevelManager MenuButton::levelManager
	LevelManager_t3355282079 * ___levelManager_3;

public:
	inline static int32_t get_offset_of_button_2() { return static_cast<int32_t>(offsetof(MenuButton_t3384838731, ___button_2)); }
	inline Button_t2872111280 * get_button_2() const { return ___button_2; }
	inline Button_t2872111280 ** get_address_of_button_2() { return &___button_2; }
	inline void set_button_2(Button_t2872111280 * value)
	{
		___button_2 = value;
		Il2CppCodeGenWriteBarrier(&___button_2, value);
	}

	inline static int32_t get_offset_of_levelManager_3() { return static_cast<int32_t>(offsetof(MenuButton_t3384838731, ___levelManager_3)); }
	inline LevelManager_t3355282079 * get_levelManager_3() const { return ___levelManager_3; }
	inline LevelManager_t3355282079 ** get_address_of_levelManager_3() { return &___levelManager_3; }
	inline void set_levelManager_3(LevelManager_t3355282079 * value)
	{
		___levelManager_3 = value;
		Il2CppCodeGenWriteBarrier(&___levelManager_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
