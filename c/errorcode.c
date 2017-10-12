void main()
{

    unsigned char name[10]="ERPDIR",buff[30];
    (char *)buff = ASCII2HEX(name,buff);
    printf("The HEX Value is %s\n", buff);

}
char *ASCII2HEX(unsigned char *Response,unsigned char *buff)
{
    int len,hexlen=0,i=0;
    unsigned char BUFF[512]="";
#ifdef PRINT_CONSOLE
    printf("\n###### ASCII2HEX:");
#endif
    len = strlen((char*)Response);
    for(i=0;i<len;i++)
    {
        sprintf((char*)BUFF+(2*i),"%02X",Response[i]);
#ifdef PRINT_CONSOLE
        printf("%02X ",Response[i]);
#endif
    }
    printf("\n");
    BUFF[2*i]='\0';
    hexlen=len;
    memset(buff,0,sizeof(buff));
    AsciiStr2HexByte((const char*)BUFF,len*2,buff,&hexlen);
    buff[hexlen]='\0';
    return 0;
}
