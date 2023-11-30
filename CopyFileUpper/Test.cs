USING SYSTEM;


    STRING SFROM;
    STRING STO;


    TRY
    {

       STREAMREADER SRFROM;
       STREAMWRITER SWTO;

       CONSOLE.WRITELINE("ВВЕДИТЕ ИМЯ ВХОДНОГО ФАЙЛА");

        SFROM = CONSOLE.READLINE();

        CONSOLE.WRITELINE("ВВЕДИТЕ ИМЯ ВЫХОДНОГО ФАЙЛА");

        STO = CONSOLE.READLINE();


       SRFROM= NEW STREAMREADER(SFROM);

       SWTO = NEW STREAMWRITER(STO);


       WHILE(SRFROM.PEEK() != -1)
    {
        STRING SBUFFER = SRFROM.READLINE();
       SBUFFER = SBUFFER.TOUPPER();

        SWTO.WRITELINE(SBUFFER);
    }

    SRFROM.CLOSE();
    SWTO.CLOSE();


}
CATCH (FILENOTFOUNDEXCEPTION E)
    {
        CONSOLE.WRITELINE("ФАЙЛ НЕ БЫЛ НАЙДЕН");

    } CATCH (EXCEPTION E)
    {
        CONSOLE.WRITELINE($"ВОЗНИКЛА ОШИБКА. ПОДРОБНОСТИ: {E.TOSTRING()}");
    }



