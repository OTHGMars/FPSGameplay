//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

//--- grenade.dae MATERIALS BEGIN ---
singleton Material(grenade_grenade)
{
	mapTo = "grenade";

	diffuseMapAsset[0] = "FPSGameplay:Grenade2_Diff_image";
	normalMapAsset[0] = "FPSGameplay:Grenade2_Norm_image";
	specularMap[0] = "Grenade2_Spec";

	diffuseColor[0] = "1 1 1 0";
	specular[0] = "1 1 1 1";
	specularPower[0] = 8;
	pixelSpecular[0] = false;
	emissive[0] = false;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   castDynamicShadows = true;    
	materialTag0 = "Weapon";
};

//--- grenade.dae MATERIALS END ---


singleton Material(debri_debris)
{
   mapTo = "debris";
   diffuseColor[0] = "0.7 0.7 0.7 1";
   diffuseMapAsset[0] = "FPSGameplay:rock_d_image";
   normalMapAsset[0] = "FPSGameplay:rock_n_image";
   specularMap[0] = "rock_s";
   specular[0] = "1 1 1 0";
   specularPower[0] = "50";   
   castShadows = "0";
   translucentBlendOp = "None";
   materialTag0 = "Weapon";
   materialTag0 = "FX";
};
