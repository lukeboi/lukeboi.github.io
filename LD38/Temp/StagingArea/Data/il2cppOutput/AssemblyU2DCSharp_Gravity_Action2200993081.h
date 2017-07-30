#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"

// UnityEngine.GameObject[]
struct GameObjectU5BU5D_t3057952154;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Gravity_Action
struct  Gravity_Action_t2200993081  : public MonoBehaviour_t1158329972
{
public:
	// System.Single Gravity_Action::maxGravity
	float ___maxGravity_2;
	// UnityEngine.Vector3 Gravity_Action::startforce
	Vector3_t2243707580  ___startforce_3;
	// System.Int32 Gravity_Action::i
	int32_t ___i_4;
	// UnityEngine.GameObject[] Gravity_Action::planets
	GameObjectU5BU5D_t3057952154* ___planets_5;

public:
	inline static int32_t get_offset_of_maxGravity_2() { return static_cast<int32_t>(offsetof(Gravity_Action_t2200993081, ___maxGravity_2)); }
	inline float get_maxGravity_2() const { return ___maxGravity_2; }
	inline float* get_address_of_maxGravity_2() { return &___maxGravity_2; }
	inline void set_maxGravity_2(float value)
	{
		___maxGravity_2 = value;
	}

	inline static int32_t get_offset_of_startforce_3() { return static_cast<int32_t>(offsetof(Gravity_Action_t2200993081, ___startforce_3)); }
	inline Vector3_t2243707580  get_startforce_3() const { return ___startforce_3; }
	inline Vector3_t2243707580 * get_address_of_startforce_3() { return &___startforce_3; }
	inline void set_startforce_3(Vector3_t2243707580  value)
	{
		___startforce_3 = value;
	}

	inline static int32_t get_offset_of_i_4() { return static_cast<int32_t>(offsetof(Gravity_Action_t2200993081, ___i_4)); }
	inline int32_t get_i_4() const { return ___i_4; }
	inline int32_t* get_address_of_i_4() { return &___i_4; }
	inline void set_i_4(int32_t value)
	{
		___i_4 = value;
	}

	inline static int32_t get_offset_of_planets_5() { return static_cast<int32_t>(offsetof(Gravity_Action_t2200993081, ___planets_5)); }
	inline GameObjectU5BU5D_t3057952154* get_planets_5() const { return ___planets_5; }
	inline GameObjectU5BU5D_t3057952154** get_address_of_planets_5() { return &___planets_5; }
	inline void set_planets_5(GameObjectU5BU5D_t3057952154* value)
	{
		___planets_5 = value;
		Il2CppCodeGenWriteBarrier(&___planets_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
