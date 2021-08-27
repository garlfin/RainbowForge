﻿using System.Diagnostics.CodeAnalysis;

namespace RainbowForge.Model
{
	[SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Enum member values are the CRC32 of the exact member name")]
	public enum BoneId : uint
	{
		Root = 0xb6c65665,
		Hips = 0xded10611,
		Spine = 0x530ec1cb,
		Spine1 = 0x8f39fa4e,
		Spine2 = 0x1630abf4,
		Neck = 0x8023796d,
		Head = 0x7c159a2,
		RightShoulder = 0xf60647e5,
		RightArm = 0x6bb3f727,
		RightForeArm = 0x7257a1aa,
		RightHand = 0x75f94d30,
		RightHandThumb1 = 0x9829becf,
		RightHandThumb2 = 0x120ef75,
		RightHandThumb3 = 0x7627dfe3,
		RightHandRing1 = 0xdbf635c5,
		RightHandRing2 = 0x42ff647f,
		RightHandRing3 = 0x35f854e9,
		RightHandMiddle1 = 0x45445772,
		RightHandMiddle2 = 0xdc4d06c8,
		RightHandMiddle3 = 0xab4a365e,
		RightHandIndex1 = 0xfebac1b3,
		RightHandIndex2 = 0x67b39009,
		RightHandIndex3 = 0x10b4a09f,
		RightHandCup = 0x2a0d8811,
		RightHandPinky1 = 0x147bb2df,
		RightHandPinky2 = 0x8d72e365,
		RightHandPinky3 = 0xfa75d3f3,
		R_RightForeArmRoll_U = 0x637d11c4,
		R_RightForeArmRoll_D = 0x9cd3136,
		C_RightElbow = 0xee3f1ccb,
		R_RightArmRoll_U = 0xfee9f290,
		R_RightArmRoll_D = 0x9459d262,
		Fx_Temple_R = 0xdfff7b8d,
		Fx_Temple_L = 0x25f046ee,
		Fx_Nose_R = 0x40498122,
		Fx_Nose_M = 0xcd418cd7,
		Fx_Nose_L = 0xba46bc41,
		Fx_Mouth_UR = 0x5e0f376e,
		Fx_Mouth_UL = 0xa4000a0d,
		Fx_Mouth_U = 0xdea4100c,
		Fx_Mouth_R = 0x40c085af,
		Fx_Mouth_L = 0xbacfb8cc,
		Fx_Jaw_R1 = 0xa363c4eb,
		Fx_Jaw_M = 0x5da6e280,
		Fx_Tongue = 0x942592d4,
		Fx_Mouth_DR = 0xdd6147e,
		Fx_Mouth_DL = 0xf7d9291d,
		Fx_Mouth_D = 0xb41430fe,
		Fx_Jaw_R2 = 0x3a6a9551,
		Fx_Jaw_L2 = 0xee2baa8e,
		Fx_Chin_R = 0x7d0616f6,
		Fx_Chin_M = 0xf00e1b03,
		Fx_Chin_L = 0x87092b95,
		Fx_Jaw_L1 = 0x7722fb34,
		Fx_Eyelid_RU = 0xfddd5cd4,
		Fx_Eyelid_RD = 0x976d7c26,
		Fx_Eyelid_LU = 0x299c630b,
		Fx_Eyelid_LD = 0x432c43f9,
		Fx_Eyebrow_R2 = 0xf7774fcd,
		Fx_Eyebrow_R1 = 0x6e7e1e77,
		Fx_Eyebrow_M = 0x977aed75,
		Fx_Eyebrow_L2 = 0x23367012,
		Fx_Eyebrow_L1 = 0xba3f21a8,
		Fx_Eye_R = 0xd8f170ca,
		Fx_Eye_L = 0x22fe4da9,
		Fx_Ear_R = 0x5435ba4f,
		Fx_Ear_L = 0xae3a872c,
		Fx_Cheek_R4 = 0x29515a3f,
		Fx_Cheek_R3 = 0xb735cf9c,
		Fx_Cheek_R2 = 0xc032ff0a,
		Fx_Cheek_R1 = 0x593baeb0,
		Fx_Cheek_L4 = 0xfd1065e0,
		Fx_Cheek_L3 = 0x6374f043,
		Fx_Cheek_L2 = 0x1473c0d5,
		Fx_Cheek_L1 = 0x8d7a916f,
		Fx_Throat = 0x76c700fc,
		Fx_Chin_Up = 0x99e55949,
		LeftShoulder = 0x2d4660a8,
		LeftArm = 0xeb830ada,
		R_LeftArmRoll_U = 0xd190180d,
		R_LeftArmRoll_D = 0xbb2038ff,
		LeftForeArm = 0x89b93a80,
		R_LeftForeArmRoll_U = 0xdd0e822d,
		R_LeftForeArmRoll_D = 0xb7bea2df,
		LeftHand = 0xb675f36c,
		LeftHandThumb1 = 0x78f4e1ac,
		LeftHandThumb2 = 0xe1fdb016,
		LeftHandThumb3 = 0x96fa8080,
		LeftHandRing1 = 0xd34048cf,
		LeftHandRing2 = 0x4a491975,
		LeftHandRing3 = 0x3d4e29e3,
		LeftHandMiddle1 = 0x911fbacf,
		LeftHandMiddle2 = 0x816eb75,
		LeftHandMiddle3 = 0x7f11dbe3,
		LeftHandIndex1 = 0x1e679ed0,
		LeftHandIndex2 = 0x876ecf6a,
		LeftHandIndex3 = 0xf069fffc,
		LeftHandCup = 0xd1e3133b,
		LeftHandPinky1 = 0xf4a6edbc,
		LeftHandPinky2 = 0x6dafbc06,
		LeftHandPinky3 = 0x1aa88c90,
		C_LeftElbow = 0x32fe6838,
		RightUpLeg = 0x757f1291,
		RightLeg = 0x863d09fc,
		RightFoot = 0x9b14362c,
		RightToeBase = 0x42be0fcb,
		C_RightKnee = 0x72d84bd7,
		C_RightAss = 0xd6697e1e,
		L_RightThigh = 0x7cdc2c3,
		LeftUpLeg = 0x176183f0,
		LeftLeg = 0x60df401,
		LeftFoot = 0x58988870,
		LeftToeBase = 0xb95094e1,
		C_LeftKnee = 0x65a177f9,
		C_LeftAss = 0x18eb1380,
		L_LeftThigh = 0x3a60dd87,
		CameraNode = 0xa9cefd4a,
		GroundNode = 0xac67f5a7,
		BONE_ROOT_OFFSET = 0x22e53c03,
		BONE_FX_TEETH_DOWN = 0x9e64f428,
		BONE_R65_BA_ROOT = 0x6aee6df1,
		BONE_R65_BA_L_HAND = 0x2897bdcb,
		BONE_R65_BA_R_HAND = 0x114bde20,
		BONE_R65_BA_R_UPPERARM = 0xc393ae8e,
		BONE_R65_BA_CAMERA = 0xc12857fb,
		BONE_SOCKET_ATT_GUN3RD = 0x2325860,
		BONE_SOCKET_ATT_SLEDGEHAMMER = 0x26322f6a,
		BONE_SOCKET_ATT_CANISTER = 0x37a967d3
	}
}