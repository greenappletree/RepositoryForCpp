#include <iostream>
#include <cstdio>
using namespace std;
//demo ���ڴ��ļ�β��������
int main()
{
    //cout << "Hello world!" << endl;
    FILE *fp;
    fp=fopen("file.txt","a+");
    //fseek(fp);
    //cout<<"4 5 6"<<endl;
    fprintf(fp,"4 5 6");
    fclose(fp);
    return 0;
}
