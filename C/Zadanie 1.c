#include "stdlib.h"
#include "math.h"

double sredniageo(double w, double x, double y, double z, double pier){
    double liczba = w*x*y*z;
    double stopienpierwiastka = pier;
    double srednia = pow(liczba,1.0/stopienpierwiastka);
    return srednia;
}

int main(){

    double w, x, y, z, pier;

    printf("Wpisz wartosc stopnia pierwiastka: \n");
    scanf("%lf",&pier);

    printf("Wpisz liczbe w: \n");
    scanf("%lf",&w);

    printf("Wpisz liczbe w: \n");
    scanf("%lf",&x);

    printf("Wpisz liczbe w: \n");
    scanf("%lf",&y);

    printf("Wpisz liczbe w: \n");
    scanf("%lf",&z);



    if(pier>0){

        double wynik = sredniageo(w,x,y,z,pier);
        printf("Wynik to: %lf \n",wynik);

    }
    else{

        printf("Nieprawidlowy stopien pierwiastka! ");

    }

}
