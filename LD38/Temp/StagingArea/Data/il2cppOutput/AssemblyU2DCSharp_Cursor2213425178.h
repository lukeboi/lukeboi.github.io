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

// UnityEngine.Camera
struct Camera_t189460977;
// UnityEngine.GameObject
struct GameObject_t1756533147;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Cursor
struct  Cursor_t2213425178  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Camera Cursor::c
	Camera_t189460977 * ___c_2;
	// UnityEngine.Vector3 Cursor::pos
	Vector3_t2243707580  ___pos_3;
	// UnityEngine.GameObject Cursor::planet
	GameObject_t1756533147 * ___planet_4;

public:
	inline static int32_t get_offset_of_c_2() { return static_cast<int32_t>(offsetof(Cursor_t2213425178, ___c_2)); }
	inline Camera_t189460977 * get_c_2() const { return ___c_2; }
	inline Camera_t189460977 ** get_address_of_c_2() { return &___c_2; }
	inline void set_c_2(Camera_t189460977 * value)
	{
		___c_2 = value;
		Il2CppCodeGenWriteBarrier(&___c_2, value);
	}

	inline static int32_t get_offset_of_pos_3() { return static_cast<int32_t>(offsetof(Cursor_t2213425178, ___pos_3)); }
	inline Vector3_t2243707580  get_pos_3() const { return ___pos_3; }
	inline Vector3_t2243707580 * get_address_of_pos_3() { return &___pos_3; }
	inline void set_pos_3(Vector3_t2243707580  value)
	{
		___pos_3 = value;
	}

	inline static int32_t get_offset_of_planet_4() { return static_cast<int32_t>(offsetof(Cursor_t2213425178, ___planet_4)); }
	inline GameObject_t1756533147 * get_planet_4() const { return ___planet_4; }
	inline GameObject_t1756533147 ** get_address_of_planet_4() { return &___planet_4; }
	inline void set_planet_4(GameObject_t1756533147 * value)
	{
		___planet_4 = value;
		Il2CppCodeGenWriteBarrier(&___planet_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
