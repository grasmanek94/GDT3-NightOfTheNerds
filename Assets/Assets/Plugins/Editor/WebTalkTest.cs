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
	[Test]
	public void WebTalkTest1() {
        done = false;
        fail = false;
        counter = 0;

        WebTalk webtalk = new WebTalk();

        webtalk.OnRegisterSuccess += Webtalk_OnRegisterSuccess;
        webtalk.OnScoreAdded += Webtalk_OnScoreAdded;
        webtalk.OnScoreFailed += Webtalk_OnScoreFailed;
        webtalk.OnRegisterFail += Webtalk_OnRegisterFail;

        webtalk.register();
        while (!done && counter < (2000/16)) { Thread.Sleep(16); ++counter; }

        Assert.IsTrue(webtalk.Registered);
        Assert.IsFalse(fail);
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
