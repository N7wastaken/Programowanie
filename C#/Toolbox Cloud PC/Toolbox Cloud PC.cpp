#include<iostream>
#include<windows.h>
#include<string>
using namespace std;

int main(){
	
	
	int wybor;
	cout<<"[1] Intranet ";
	cout<<endl;
	cout<<"[2] Security Portal ";
	cout<<endl;
	cout<<"[3] Mail ";
	cout<<endl;
	cout<<"[4] Service Desk ";
	cout<<endl;
	cout<<"[5] TETA HRM ";
	cout<<endl;
	cout<<"[6] SW DYSK ";
	cout<<endl;
	
	cin>>wybor;
	
	if(wybor==1){
		system("start https://lgema.lge.com/index.php?action=security");
	}
	else if(wybor==2){
		system("start http://security.lge.com:5030/login.LoginDo.public.laf");
		
	}
	else if(wybor==3){
		system("start http://sso.lge.com");
		
	}
	else if(wybor==4){
		system("start https://lgema.lge.com/index.php?action=login");
		
	}
	else if(wybor==5){
		system("start http://teta.lge.com:8080/hrm/login.html");
		
	}
	else if(wybor==6){
		system("cd C:\\Users\\arkadiusz.mulkityn\\Desktop\\Toolbox Cloud PC");
		system("start SW.bat");
		
	}
	
	return 0;
}
