#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// UnityEngine.GameObject
struct GameObject_t1756533147;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Killer
struct  Killer_t1425258763  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject Killer::Lost
	GameObject_t1756533147 * ___Lost_2;
	// UnityEngine.GameObject Killer::burst
	GameObject_t1756533147 * ___burst_3;
	// UnityEngine.GameObject Killer::canvas
	GameObject_t1756533147 * ___canvas_4;

public:
	inline static int32_t get_offset_of_Lost_2() { return static_cast<int32_t>(offsetof(Killer_t1425258763, ___Lost_2)); }
	inline GameObject_t1756533147 * get_Lost_2() const { return ___Lost_2; }
	inline GameObject_t1756533147 ** get_address_of_Lost_2() { return &___Lost_2; }
	inline void set_Lost_2(GameObject_t1756533147 * value)
	{
		___Lost_2 = value;
		Il2CppCodeGenWriteBarrier(&___Lost_2, value);
	}

	inline static int32_t get_offset_of_burst_3() { return static_cast<int32_t>(offsetof(Killer_t1425258763, ___burst_3)); }
	inline GameObject_t1756533147 * get_burst_3() const { return ___burst_3; }
	inline GameObject_t1756533147 ** get_address_of_burst_3() { return &___burst_3; }
	inline void set_burst_3(GameObject_t1756533147 * value)
	{
		___burst_3 = value;
		Il2CppCodeGenWriteBarrier(&___burst_3, value);
	}

	inline static int32_t get_offset_of_canvas_4() { return static_cast<int32_t>(offsetof(Killer_t1425258763, ___canvas_4)); }
	inline GameObject_t1756533147 * get_canvas_4() const { return ___canvas_4; }
	inline GameObject_t1756533147 ** get_address_of_canvas_4() { return &___canvas_4; }
	inline void set_canvas_4(GameObject_t1756533147 * value)
	{
		___canvas_4 = value;
		Il2CppCodeGenWriteBarrier(&___canvas_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
