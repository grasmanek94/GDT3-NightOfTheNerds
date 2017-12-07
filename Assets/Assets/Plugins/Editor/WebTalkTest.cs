using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using NerdOfTheNight;
using System.Threading;

public class WebTalkTest {

    bool done;
    bool fail;
    int counter;

    [SetUp]
    public void InitTest()
    {
        done = false;
        fail = false;
        counter = 0;
    }

    [TearDown]
    public void DeinitTest()
    {

    }

	[Test]
	public void WebTalkTest1() {
        WebTalk webtalk = new WebTalk();

        webtalk.OnRegisterSuccess += Webtalk_OnRegisterSuccess;
        webtalk.OnScoreAdded += Webtalk_OnScoreAdded;
        webtalk.OnScoreFailed += Webtalk_OnScoreFailed;
        webtalk.OnRegisterFail += Webtalk_OnRegisterFail;

        webtalk.register();
        webtalk.add_score("6AE8E9AF0D4BFA1854097E15D5BE5C07B46B81B45");

        Assert.IsFalse(fail);
        Assert.IsTrue(webtalk.Registered);
        Assert.IsNotEmpty(webtalk.Name);
    }

    private void Webtalk_OnRegisterFail(WebTalk webtalk, string name)
    {
        done = true;
        fail = true;
    }

    private void Webtalk_OnScoreFailed(WebTalk webtalk, string score)
    {
        done = true;
        fail = true;
    }

    private void Webtalk_OnScoreAdded(WebTalk webtalk, string score)
    {
        done = true;
    }

    private void Webtalk_OnRegisterSuccess(WebTalk webtalk, string name)
    {
        done = true;
    }
}
