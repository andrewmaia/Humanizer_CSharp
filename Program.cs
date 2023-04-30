//https://github.com/Humanizr/Humanizer
using Humanizer;

Console.WriteLine("FraseEmPascalCase".Humanize());
Console.WriteLine("Frase_separada_por_underscore".Humanize());
Console.WriteLine("HUMANIZER".Transform(To.LowerCase, To.TitleCase));
Console.WriteLine("sempre_iniciando_com_maiusculo".Humanize(LetterCasing.Title));
Console.WriteLine("Pascal case input string is turned into sentence".Dehumanize());
Console.WriteLine("Truncar um texto que é muito longo".Truncate(13,"..."));

//Pascalizar
Console.WriteLine("Alguma_coisa para pascalizar".Pascalize() );

//Camelizar
Console.WriteLine("Alguma_coisa para Camelizar".Camelize() );

//Datas e Horas
Console.WriteLine(DateTime.UtcNow.AddHours(-30).Humanize());
Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
Console.WriteLine(TimeSpan.FromMilliseconds(2000).Humanize());
Console.WriteLine(TimeSpan.FromMilliseconds(3603001).Humanize(3));

//Gerar datetime ou TimeSpan a partir do termo humanizado
TimeSpan t1 = 2.Milliseconds();
Console.WriteLine(t1.ToString());
TimeSpan t2 = 2.Days();
Console.WriteLine(t2.ToString());

//Gerar numeros a partir do termo humanizado
long l1 = 1.Billions();
Console.WriteLine(l1.ToString());
long l2 = 3.Hundreds().Thousands();
Console.WriteLine(l2.ToString());


//Plural
Console.WriteLine("casa".Pluralize());

//Singular
Console.WriteLine("casas".Singularize());

//Quantiidade
Console.WriteLine("carro".ToQuantity(10));

//Números ordinários
Console.WriteLine(1.Ordinalize());
Console.WriteLine(6.Ordinalize());

//Trabalhando com Bits e Bytes
var fileSize = (1).Megabytes();
Console.WriteLine(fileSize.Bits);
Console.WriteLine(fileSize.Bytes);
Console.WriteLine(fileSize.Kilobytes);
Console.WriteLine(fileSize.Megabytes);
