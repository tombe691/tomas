void part1(int argc,char *argv[]) {
    if (argc == 3){
        printf("tal 1: %d plus tal 2: %d  = %d\n",atoi(argv[1]), atoi(argv[2]), (atoi(argv[1])+ atoi(argv[2])));
    }
    else {
        printf("fel antal argument");
    }
}

int main(int argc,char *argv[])
{
    part1(argc, argv);
    return 0;
}
