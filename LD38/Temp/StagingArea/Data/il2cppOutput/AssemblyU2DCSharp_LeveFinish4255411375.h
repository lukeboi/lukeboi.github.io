#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

// System.String
struct String_t;




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// LeveFinish
struct  LeveFinish_t4255411375  : public MonoBehaviour_t1158329972
{
public:
	// System.String LeveFinish::menuname
	String_t* ___menuname_2;

public:
	inline static int32_t get_offset_of_menuname_2() { return static_cast<int32_t>(offsetof(LeveFinish_t4255411375, ___menuname_2)); }
	inline String_t* get_menuname_2() const { return ___menuname_2; }
	inline String_t** get_address_of_menuname_2() { return &___menuname_2; }
	inline void set_menuname_2(String_t* value)
	{
		___menuname_2 = value;
		Il2CppCodeGenWriteBarrier(&___menuname_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
