using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("11912345678", "NOKIA", "123456", 16);
nokia.InstalarAplicativo("Instagram");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.ExibirDadosTelefone();

Iphone iphone = new Iphone("31912345679", "IPHONE", "78945612", 64);
iphone.ExibirDadosTelefone();
iphone.InstalarAplicativo("Telegram");
iphone.Ligar();
iphone.ReceberLigacao();
