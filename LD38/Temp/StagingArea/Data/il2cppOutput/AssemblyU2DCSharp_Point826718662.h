#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.Rigidbody2D
struct Rigidbody2D_t502193897;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.GameObject[]
struct GameObjectU5BU5D_t3057952154;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Point
struct  Point_t826718662  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Rigidbody2D Point::r
	Rigidbody2D_t502193897 * ___r_2;
	// UnityEngine.GameObject Point::c
	GameObject_t1756533147 * ___c_3;
	// UnityEngine.GameObject[] Point::cursors
	GameObjectU5BU5D_t3057952154* ___cursors_4;

public:
	inline static int32_t get_offset_of_r_2() { return static_cast<int32_t>(offsetof(Point_t826718662, ___r_2)); }
	inline Rigidbody2D_t502193897 * get_r_2() const { return ___r_2; }
	inline Rigidbody2D_t502193897 ** get_address_of_r_2() { return &___r_2; }
	inline void set_r_2(Rigidbody2D_t502193897 * value)
	{
		___r_2 = value;
		Il2CppCodeGenWriteBarrier(&___r_2, value);
	}

	inline static int32_t get_offset_of_c_3() { return static_cast<int32_t>(offsetof(Point_t826718662, ___c_3)); }
	inline GameObject_t1756533147 * get_c_3() const { return ___c_3; }
	inline GameObject_t1756533147 ** get_address_of_c_3() { return &___c_3; }
	inline void set_c_3(GameObject_t1756533147 * value)
	{
		___c_3 = value;
		Il2CppCodeGenWriteBarrier(&___c_3, value);
	}

	inline static int32_t get_offset_of_cursors_4() { return static_cast<int32_t>(offsetof(Point_t826718662, ___cursors_4)); }
	inline GameObjectU5BU5D_t3057952154* get_cursors_4() const { return ___cursors_4; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_cursors_4() { return &___cursors_4; }
	inline void set_cursors_4(GameObjectU5BU5D_t3057952154* value)
	{
		___cursors_4 = value;
		Il2CppCodeGenWriteBarrier(&___cursors_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
