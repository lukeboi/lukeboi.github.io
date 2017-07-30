#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.GameObject[]
struct GameObjectU5BU5D_t3057952154;
// UnityEngine.UI.Text
struct Text_t356221433;
// UnityEngine.GameObject
struct GameObject_t1756533147;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Planet_Counter
struct  Planet_Counter_t1304266435  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject[] Planet_Counter::planets
	GameObjectU5BU5D_t3057952154* ___planets_2;
	// UnityEngine.UI.Text Planet_Counter::me
	Text_t356221433 * ___me_3;
	// UnityEngine.GameObject Planet_Counter::Win
	GameObject_t1756533147 * ___Win_4;
	// UnityEngine.GameObject Planet_Counter::w
	GameObject_t1756533147 * ___w_5;

public:
	inline static int32_t get_offset_of_planets_2() { return static_cast<int32_t>(offsetof(Planet_Counter_t1304266435, ___planets_2)); }
	inline GameObjectU5BU5D_t3057952154* get_planets_2() const { return ___planets_2; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_planets_2() { return &___planets_2; }
	inline void set_planets_2(GameObjectU5BU5D_t3057952154* value)
	{
		___planets_2 = value;
		Il2CppCodeGenWriteBarrier(&___planets_2, value);
	}

	inline static int32_t get_offset_of_me_3() { return static_cast<int32_t>(offsetof(Planet_Counter_t1304266435, ___me_3)); }
	inline Text_t356221433 * get_me_3() const { return ___me_3; }
	inline Text_t356221433 ** get_address_of_me_3() { return &___me_3; }
	inline void set_me_3(Text_t356221433 * value)
	{
		___me_3 = value;
		Il2CppCodeGenWriteBarrier(&___me_3, value);
	}

	inline static int32_t get_offset_of_Win_4() { return static_cast<int32_t>(offsetof(Planet_Counter_t1304266435, ___Win_4)); }
	inline GameObject_t1756533147 * get_Win_4() const { return ___Win_4; }
	inline GameObject_t1756533147 ** get_address_of_Win_4() { return &___Win_4; }
	inline void set_Win_4(GameObject_t1756533147 * value)
	{
		___Win_4 = value;
		Il2CppCodeGenWriteBarrier(&___Win_4, value);
	}

	inline static int32_t get_offset_of_w_5() { return static_cast<int32_t>(offsetof(Planet_Counter_t1304266435, ___w_5)); }
	inline GameObject_t1756533147 * get_w_5() const { return ___w_5; }
	inline GameObject_t1756533147 ** get_address_of_w_5() { return &___w_5; }
	inline void set_w_5(GameObject_t1756533147 * value)
	{
		___w_5 = value;
		Il2CppCodeGenWriteBarrier(&___w_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
