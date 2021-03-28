

/** Samples.TestLib.FloatIntSpeedTest
*/
namespace Samples.TestLib.FloatIntSpeedTest
{
	/** FloatIntSpeetTest
	*/
	public class FloatIntSpeetTest : UnityEngine.MonoBehaviour
	{
		/** speedtester
		*/
		BlueBack.TestLib.SpeedTester.SpeedTester speedtester;

		/** Start
		*/
		private void Start()
		{
			this.speedtester = new BlueBack.TestLib.SpeedTester.SpeedTester(new BlueBack.TestLib.SpeedTester.ITest[]{
				new Test_Float(),
				new Test_Int(),
			});
		}

		/** Update
		*/
		private void Update()
		{
			this.speedtester.RandomTest(Config.LOOP);
		}
	}
}
