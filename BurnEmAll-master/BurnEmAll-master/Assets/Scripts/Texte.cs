﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Texte : MonoBehaviour {
    int n = 0;
    Text texte;
    // Use this for initialization
    void Start() {
		texte = GetComponent<Text>();
		//     string message; et message = texte.text;
    }

    void Update()
    {
    if(Input.GetMouseButtonDown(0)) {
            n = n+1;
            Debug.Log(n);
               switch(n) {
                case 1:
				    texte.text = "Celui-ci ne savait pas ce qu'il faisait là. \n En plus il était nue ! Mais sa c'est une autre histoire...";
                    break;
                case 2:
				texte.text = "Alors qu'il reprenait ces esprits, \n Ceux-ci ce mirent à lui parler. \n Ces voix tantôt douces tantôt puissantes \n l'incitait à faire du mal à la nature autour de lui." ;
                    break;
                case 4:
				texte.text = " Il trouva une torche face à lui.\n La flamme lui parla, le réchauffa, le réconforta  \n mais l'entraina par la même occassion\n dans la folie et dans la déchéance de son âme.";
                    break;
                case 5:
				texte.text = "La natura lui sembla alors hostile :\n - Les lapin eurent tout à coup les yeux luisant. \n - Il pouvait voir des visages sur les fleurs.\n - Les canards avaient un comportement étrange. \n\n  TOUT CES ANIMAUX VOULAIENT SA MORT !";
                    break;

			    case 7:
				    texte.text = "Il avait sombré dans la folie ! \n Mais ne l'était-il pas déjà avant ? \n \n Tout ce qu'il savait,\n c'est que la réponse se tennait entre ses mains. ";
				    break;
			    case 8:
				texte.text = "Il comprit vite que le feu était\n l'unique solution à tout ces problèmes.\n \n Toutes les voix se mirent à chuchoter, murmurer,\n parler, crier, hurler la même chose... ";
				    break;			
                 case 9:
				    texte.text = "BURM'EM ALL.";
                    texte.fontSize = 45;
                    break;
                case 10:
					SceneManager.LoadScene ("Level1");
                    break;
            }
    }
    }
}
