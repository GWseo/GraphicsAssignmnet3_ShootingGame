using System;
using System.Runtime.InteropServices;

public class UnityBridge{


	[DllImport("GraphicsBulletPlugin")]
	public static extern float Accurate (int totalBullet, int hit);

	[DllImport("GraphicsBulletPlugin")]
	public static extern int BarrelScore(string color);

}