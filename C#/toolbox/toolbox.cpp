#include<iostream>
#include<windows.h>
#include<string>
using namespace std;

int main(){
	
	
	int wybor;
	cout<<"[1] Dev & Edge ";
	cout<<endl;
	cout<<"[2] Cloud PC ";
	cout<<endl;
	cout<<"[3] Bats";
	cout<<endl;
	
	cin>>wybor;
	
	if(wybor==1){
		system("cd C:\\Users\\arkadiusz.mulkityn\\Desktop\\toolbox ");
		system("start Edge");
		system("start Dev");
	}
	else if(wybor==2){
		system("start https://eicvpc.lge.com/vmCube/Launcher/DesktopLauncher/ViewDesktop");
		
	}
	else if(wybor==3){
		system("start notepad");
		
	}
	
	return 0;
}
