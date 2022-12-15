using System;
using System.Collections.Generic;
using System.Text;

public static class TrascrizioneRNA
{
    public static string ToRna(string dna)
    {
        if( String.IsNullOrEmpty( dna ) )
            return "";

        char[] arr = dna.ToCharArray();
        dna = "";
        for (int i = 0; i < arr.Length; i++){
            switch(arr[i]){
                case 'G':
                    dna += "C";
                    break;
                case 'C':
                    dna += "G";
                    break;
                case 'T':
                    dna += "A";
                    break;
                case 'A':
                    dna += "U";
                    break;
            }
        }

        return dna;
    }
}