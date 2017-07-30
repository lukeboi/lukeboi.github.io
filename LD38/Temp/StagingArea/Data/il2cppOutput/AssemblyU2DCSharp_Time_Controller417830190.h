#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.UI.Slider
struct Slider_t297367283;
// UnityEngine.UI.Text
struct Text_t356221433;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Time_Controller
struct  Time_Controller_t417830190  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.UI.Slider Time_Controller::slider
	Slider_t297367283 * ___slider_2;
	// UnityEngine.UI.Text Time_Controller::text
	Text_t356221433 * ___text_3;
	// System.Single Time_Controller::target
	float ___target_4;

public:
	inline static int32_t get_offset_of_slider_2() { return static_cast<int32_t>(offsetof(Time_Controller_t417830190, ___slider_2)); }
	inline Slider_t297367283 * get_slider_2() const { return ___slider_2; }
	inline Slider_t297367283 ** get_address_of_slider_2() { return &___slider_2; }
	inline void set_slider_2(Slider_t297367283 * value)
	{
		___slider_2 = value;
		Il2CppCodeGenWriteBarrier(&___slider_2, value);
	}

	inline static int32_t get_offset_of_text_3() { return static_cast<int32_t>(offsetof(Time_Controller_t417830190, ___text_3)); }
	inline Text_t356221433 * get_text_3() const { return ___text_3; }
	inline Text_t356221433 ** get_address_of_text_3() { return &___text_3; }
	inline void set_text_3(Text_t356221433 * value)
	{
		___text_3 = value;
		Il2CppCodeGenWriteBarrier(&___text_3, value);
	}

	inline static int32_t get_offset_of_target_4() { return static_cast<int32_t>(offsetof(Time_Controller_t417830190, ___target_4)); }
	inline float get_target_4() const { return ___target_4; }
	inline float* get_address_of_target_4() { return &___target_4; }
	inline void set_target_4(float value)
	{
		___target_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
