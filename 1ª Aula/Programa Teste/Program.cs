bool SubstringTest(string texto){
	// CT1 
	string s1 = texto.Substring(0); // Deve retornar “Fatec”
	if (s1 != texto){
		Console.WriteLine("Não passou no CT1.");
		return false;
	}
	// CT2
	string s2 = texto.Substring(4); // Deve retornar “c”
	if (s2 != texto[4].ToString()){
		Console.WriteLine("Não passou no CT2.");
		return false;
	}
	return true;
}

System.Console.WriteLine(SubstringTest(Console.ReadLine()));