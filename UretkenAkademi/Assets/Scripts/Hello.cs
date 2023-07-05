using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Hello : MonoBehaviour
{
    void Start()
    {
        BolunenleriBul(43, 67);
    }

    void BolunenleriBul(int ilksayi, int ikincisayi)
    {
        List<int> tumSayilar = new List<int>();
        List<int> ikiyeBolunenler = new List<int>();
        List<int> uceBolunenler = new List<int>();
        List<int> beseBolunenler = new List<int>();

        for (int i = ilksayi; i <= ikincisayi; i++)
        {
            tumSayilar.Add(i);
            if (i % 2 == 0)
            {
                ikiyeBolunenler.Add(i);
            }
            if (i % 3 == 0)
            {
                uceBolunenler.Add(i);
            }
            if (i % 5 == 0)
            {
                beseBolunenler.Add(i);
            }
        }

        //Debug.Log("Tüm Sayýlar: " + string.Join(", ", tumSayilar));
        //Debug.Log("2'ye Bölünenler: " + string.Join(", ", ikiyeBolunenler));
        //Debug.Log("3'e Bölünenler: " + string.Join(", ", uceBolunenler));
        //Debug.Log("5'e Bölünenler: " + string.Join(", ", beseBolunenler));

        StringBuilder builder = new StringBuilder();

        builder.Append("Tüm Sayýlar: ");
        for (int i = 0; i < tumSayilar.Count; i++)
        {
            builder.Append(tumSayilar[i]);
            if (i < tumSayilar.Count - 1)
            {
                builder.Append(", ");
            }
        }
        Debug.Log(builder.ToString());

        builder.Clear();

        builder.Append("2'ye Bölünenler: ");
        for (int i = 0; i < ikiyeBolunenler.Count; i++)
        {
            builder.Append(ikiyeBolunenler[i]);
            if (i < ikiyeBolunenler.Count - 1)
            {
                builder.Append(", ");
            }
        }
        Debug.Log(builder.ToString());

        builder.Clear();

        builder.Append("3'e Bölünenler: ");
        for (int i = 0; i < uceBolunenler.Count; i++)
        {
            builder.Append(uceBolunenler[i]);
            if (i < uceBolunenler.Count - 1)
            {
                builder.Append(", ");
            }
        }
        Debug.Log(builder.ToString());

        builder.Clear();

        builder.Append("5'e Bölünenler: ");
        for (int i = 0; i < beseBolunenler.Count; i++)
        {
            builder.Append(beseBolunenler[i]);
            if (i < beseBolunenler.Count - 1)
            {
                builder.Append(", ");
            }
        }
        Debug.Log(builder.ToString());
    }

}

