using Tema01;


var listaStudenti = new List<Student>();

listaStudenti.Add(new Student());
listaStudenti[0].nume = "Popescu";
listaStudenti[0].prenume = "Ion";
listaStudenti[0].initialaTata = 'S';
listaStudenti[0].codStudent = 6464;
listaStudenti[0].materii.Add(new Materie("Mate",10,"2h",7));
listaStudenti[0].materii.Add(new Materie("Sport", 6, "4h", 1));


listaStudenti.Add(new Student());
listaStudenti[1].nume = "Ionescu";
listaStudenti[1].prenume = "Andrei";
listaStudenti[1].initialaTata = 'R';
listaStudenti[1].codStudent = 5000;
listaStudenti[1].materii.Add(new Materie());


listaStudenti.Add(new Student());
listaStudenti[2].nume = "Niculescu";
listaStudenti[2].prenume = "Alexandru";
listaStudenti[2].initialaTata = 'S';
listaStudenti[2].codStudent = 5452;



foreach (Student st in listaStudenti)
{
    st.afisareNume();
    st.afisareMaterie();
}
