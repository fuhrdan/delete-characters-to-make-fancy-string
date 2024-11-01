//*****************************************************************************
//** 1957. Delete Characters to Make Fancy String    leetcode                **
//*****************************************************************************




char* makeFancyString(char* s) {
    int len = strlen(s);
    int convert = 0;
    int convert2 = 0;
    int convert3 = 0;
    char* returnString = (char*)malloc((len + 1) * sizeof(char));

    if(returnString == NULL)
    {
        printf("Memory Allocation Failure\n");
        return NULL;
    }

    int returnIndex = 0;

    for(int i = 0; i < len; i++)
    {

        convert = s[i];
        if(i+1 < len) convert2 = s[i+1];
        else convert2 = -1;
        if(i+2 < len) convert3 = s[i+2];
        else convert3 = -2;
        if((convert == convert2) && (convert3 == convert2))
        {
//            printf("Removing s[%d] = %c\n",i,s[i]);
        }
        else
        {
//            printf("Adding s[%d] = %c\n",i,s[i]);
            returnString[returnIndex++] = s[i];
         
        }

    }
    returnString[returnIndex] = '\0';
    return returnString;
}