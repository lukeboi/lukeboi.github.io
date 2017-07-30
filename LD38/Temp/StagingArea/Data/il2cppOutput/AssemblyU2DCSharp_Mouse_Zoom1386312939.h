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




#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Mouse_Zoom
struct  Mouse_Zoom_t1386312939  : public MonoBehaviour_t1158329972
{
public:
	// System.Single Mouse_Zoom::dragSpeed
	float ___dragSpeed_2;
	// UnityEngine.Camera Mouse_Zoom::Cam
	Camera_t189460977 * ___Cam_3;
	// UnityEngine.Vector3 Mouse_Zoom::dragOrigin
	Vector3_t2243707580  ___dragOrigin_4;
	// System.Boolean Mouse_Zoom::go
	bool ___go_5;

public:
	inline static int32_t get_offset_of_dragSpeed_2() { return static_cast<int32_t>(offsetof(Mouse_Zoom_t1386312939, ___dragSpeed_2)); }
	inline float get_dragSpeed_2() const { return ___dragSpeed_2; }
	inline float* get_address_of_dragSpeed_2() { return &___dragSpeed_2; }
	inline void set_dragSpeed_2(float value)
	{
		___dragSpeed_2 = value;
	}

	inline static int32_t get_offset_of_Cam_3() { return static_cast<int32_t>(offsetof(Mouse_Zoom_t1386312939, ___Cam_3)); }
	inline Camera_t189460977 * get_Cam_3() const { return ___Cam_3; }
	inline Camera_t189460977 ** get_address_of_Cam_3() { return &___Cam_3; }
	inline void set_Cam_3(Camera_t189460977 * value)
	{
		___Cam_3 = value;
		Il2CppCodeGenWriteBarrier(&___Cam_3, value);
	}

	inline static int32_t get_offset_of_dragOrigin_4() { return static_cast<int32_t>(offsetof(Mouse_Zoom_t1386312939, ___dragOrigin_4)); }
	inline Vector3_t2243707580  get_dragOrigin_4() const { return ___dragOrigin_4; }
	inline Vector3_t2243707580 * get_address_of_dragOrigin_4() { return &___dragOrigin_4; }
	inline void set_dragOrigin_4(Vector3_t2243707580  value)
	{
		___dragOrigin_4 = value;
	}

	inline static int32_t get_offset_of_go_5() { return static_cast<int32_t>(offsetof(Mouse_Zoom_t1386312939, ___go_5)); }
	inline bool get_go_5() const { return ___go_5; }
	inline bool* get_address_of_go_5() { return &___go_5; }
	inline void set_go_5(bool value)
	{
		___go_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
