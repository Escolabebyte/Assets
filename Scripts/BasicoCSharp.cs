using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicoCSharp : MonoBehaviour
{

    public int idade;
    public string nome;
    public float tempo;
    public bool temIdadeSuficiente;

    public Camera camera;

    public BasicoCSharp basico;

    private void Awake()
    {
        print("Awake");
    }

    void Start()
    {
        idade = 0;
        nome = "João";
        tempo = 50.5f;
        temIdadeSuficiente = true;

        print("Start");

        string[] nomes = new string[] { "Maria", "João", "Pedro" };

        for (int i = 0; i < nomes.Length; i++)
        {
            print(nomes[i]);
        }

        foreach (var item in nomes)
        {
            print(item);
        }

        while (idade < 18)
        {
            print("Vc é menor de idade");
            idade++;
        }

        do
        {
            if (idade == 18)
                print("Vc é maior de idade");
            else
                print("Vc é menor de idade");

            idade++;
        } while (idade < 18);


        camera.backgroundColor = Color.green;
        print(basico.idade);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {

    }

    private void LateUpdate()
    {

    }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }

    private void OnDestroy()
    {

    }

    public bool ChecarSeTemIdadeSuficiente(int idade)
    {
        if (idade == 18) return true;
        else return false;
    }
}
