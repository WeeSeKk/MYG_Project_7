using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SphereController;
using LeftHandUIController;
using UnityEngine.SceneManagement;

public class TestScript
{
    Material lobbySkybox;

    [UnityTest]
    public IEnumerator SkyboxChangeLobby()
    {
        yield return SceneManager.LoadSceneAsync("360ViewScene");

        lobbySkybox = RenderSettings.skybox;

        GameObject sphere = GameObject.Find("Sphere (1)");

        Assert.IsNotNull(sphere, "Sphere (1) not found");

        TeleportationSphereController teleportationSphereController = GameObject.Find("Sphere (1)").GetComponent<TeleportationSphereController>();

        Assert.IsNotNull(teleportationSphereController, "Script not found");

        teleportationSphereController.OnTeleport(1);

        yield return new WaitForSeconds(0.1f);

        teleportationSphereController.OnTeleport(3);

        yield return new WaitForSeconds(0.1f);

        Assert.AreSame(lobbySkybox, RenderSettings.skybox);
    }

    [UnityTest]
    public IEnumerator SkyboxChangeTest1()
    {
        yield return SceneManager.LoadSceneAsync("360ViewScene");

        lobbySkybox = RenderSettings.skybox;

        GameObject sphere = GameObject.Find("Sphere (1)");

        Assert.IsNotNull(sphere, "Sphere (1) not found");

        TeleportationSphereController teleportationSphereController = GameObject.Find("Sphere (1)").GetComponent<TeleportationSphereController>();

        Assert.IsNotNull(teleportationSphereController, "Script not found");

        teleportationSphereController.OnTeleport(1);

        yield return new WaitForSeconds(0.1f);

        Assert.AreNotSame(lobbySkybox, RenderSettings.skybox);
    }

    [UnityTest]
    public IEnumerator SkyboxChangeTest2()
    {
        yield return SceneManager.LoadSceneAsync("360ViewScene");

        GameObject sphere = GameObject.Find("Sphere (1)");

        Assert.IsNotNull(sphere, "Sphere (1) not found");

        TeleportationSphereController teleportationSphereController = GameObject.Find("Sphere (1)").GetComponent<TeleportationSphereController>();

        Assert.IsNotNull(teleportationSphereController, "Script not found");

        teleportationSphereController.OnTeleport(2);

        yield return new WaitForSeconds(0.1f);

        Assert.AreNotSame(lobbySkybox, RenderSettings.skybox);
    }

    [UnityTest]
    public IEnumerator SkyboxChangeTest3()
    {
        yield return SceneManager.LoadSceneAsync("360ViewScene");

        GameObject sphere = GameObject.Find("Sphere (1)");

        Assert.IsNotNull(sphere, "Sphere (1) not found");

        TeleportationSphereController teleportationSphereController = GameObject.Find("Sphere (1)").GetComponent<TeleportationSphereController>();

        Assert.IsNotNull(teleportationSphereController, "Script not found");

        teleportationSphereController.OnTeleport(4);

        yield return new WaitForSeconds(0.1f);

        Assert.AreNotSame(lobbySkybox, RenderSettings.skybox);
    }

    [UnityTest]
    public IEnumerator SkyboxChangeTest4()
    {
        yield return SceneManager.LoadSceneAsync("360ViewScene");

        GameObject sphere = GameObject.Find("Sphere (1)");

        Assert.IsNotNull(sphere, "Sphere (1) not found");

        TeleportationSphereController teleportationSphereController = GameObject.Find("Sphere (1)").GetComponent<TeleportationSphereController>();

        Assert.IsNotNull(teleportationSphereController, "Script not found");

        teleportationSphereController.OnTeleport(5);

        yield return new WaitForSeconds(0.1f);

        Assert.AreNotSame(lobbySkybox, RenderSettings.skybox);
    }
    
}