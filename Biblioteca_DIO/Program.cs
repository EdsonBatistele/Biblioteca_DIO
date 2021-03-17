using System;
using System.Globalization;



namespace Biblioteca_DIO

{
    public static class Program
    {
        static BibliotecaSeries bibliotecaSeries = new BibliotecaSeries();
        static BibliotecaFilmes bibliotecaFilmes = new BibliotecaFilmes();
        static BibliotecaDocumentarios bibliotecaDocumentarios = new BibliotecaDocumentarios();
        static BibliotecaAnimes bibliotecaAnimes = new BibliotecaAnimes();
        static void Main(string[] args)
        {
            var sairMenuPrincipal = false;
            string opcaoMenu = MenuPrincipal();
            while (!sairMenuPrincipal)
            {
                switch (opcaoMenu.ToUpper())
                {
                    case "1":       //Controle do Menu de Series
                        {
                            var sairMenuSeries = false;
                            while (!sairMenuSeries)
                            {
                                string opcaoSeries = MenuSeries();
                                switch (opcaoSeries)
                                {
                                    case "1":
                                        {
                                            CadastrarSerie();
                                        }
                                        break;
                                    case "2":
                                        {
                                            AlterarSerie();
                                        }
                                        break;
                                    case "3":
                                        {
                                            RemoverSerie();
                                        }
                                        break;
                                    case "4":
                                        {
                                            ListarSeries();
                                        }
                                        break;
                                    case "5":
                                        {
                                            VisualizarSerie();
                                        }
                                        break;
                                    case "6":
                                        {
                                            sairMenuSeries = true;
                                            break;
                                        }

                                }
                            }
                            break;
                        }

                    case "2":       //Controle do Menu de Filmes 
                        {
                            var sairMenuFilmes = false;
                            while (!sairMenuFilmes)
                            {
                                var opcaoSeries = MenuFilmes();
                                switch (opcaoSeries)
                                {
                                    case "1":
                                        {
                                             CadastrarFilme();
                                        }
                                        break;
                                    case "2":
                                        {
                                             AlterarFilme();
                                        }
                                        break;
                                    case "3":
                                        {
                                             RemoverFilme();
                                        }
                                        break;
                                    case "4":
                                        {
                                             ListarFilmes();
                                        }
                                        break;
                                    case "5":
                                        {
                                              VisualizarFilme();
                                        }
                                        break;
                                    case "6":
                                        sairMenuFilmes = true;
                                        break;
                                }
                            }
                            break;
                        }
                    case "3":       //Controle do menu de Documentários 
                        {
                            var sairMenuDocumentarios = false;
                            while (!sairMenuDocumentarios)
                            {
                                var opcaoSeries = MenuDocumentarios();
                                switch (opcaoSeries)
                                {
                                    case "1":
                                        {
                                             CadastrarDocumentario();
                                        }
                                        break;
                                    case "2":
                                        {
                                              AlterarDocumentario();
                                        }
                                        break;
                                    case "3":
                                        {
                                              RemoverDocumentario();
                                        }
                                        break;
                                    case "4":
                                        {
                                              ListarDocumentarios();
                                        }
                                        break;
                                    case "5":
                                        {
                                              VisualizarDocumentario();
                                        }
                                        break;
                                    case "6":
                                        {
                                            sairMenuDocumentarios = true;
                                            break;
                                        }
                                }
                            }
                            break;
                        }

                    case "4":           //Controle do menu de Animes                                                         
                        {
                            var sairMenuAnimes = false;
                            while (!sairMenuAnimes)
                            {
                                var opcaoSeries = MenuAnimes();
                                switch (opcaoSeries)
                                {
                                    case "1":
                                        {
                                             CadastrarAnime();
                                        }
                                        break;
                                    case "2":
                                        {
                                              AlterarAnime();
                                        }
                                        break;
                                    case "3":
                                        {
                                              RemoverAnime();
                                        }
                                        break;
                                    case "4":
                                        {
                                              ListarAnimes();
                                        }
                                        break;
                                    case "5":
                                        {
                                             VisualizarAnime();
                                        }
                                        break;
                                    case "6":
                                        sairMenuAnimes = true;
                                        break;
                                }
                            }
                            break;
                        }

                    case "5":       //Encerra o programa                                                               
                        {
                            Console.WriteLine("Deseja realmente sair (S/N)");
                            string op = Console.ReadLine().ToUpper();
                            if (op == "S")
                            {
                                sairMenuPrincipal = true;
                            }
                        }
                        break;

                }
                if (!sairMenuPrincipal)
                {
                    opcaoMenu = MenuPrincipal();

                }
            }

        }
        //METODOS PARA SERIES
        private static void CadastrarSerie()
        {
            Console.WriteLine("----------------------- ");
            Console.WriteLine("CADASTRAR SÉRIE");
            Console.WriteLine("-----------------------\n ");


            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.Write("Digite o número do Gênero entre as opções acima: ");
            int entradaGenero = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaGenero) || !(entradaGenero > 0 && entradaGenero <= 12))
            {
                Console.WriteLine("A opção deve ser de tipo númerico!");
                Console.Write("\nInsira um valor entre 1 e 12 :  ");
            }


            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();
            while (entradaTitulo == "" || entradaTitulo == null)
            {
                Console.WriteLine("Título não pode ficar vazio");
                Console.Write("\nDigite o Título da Série  :   ");
                entradaTitulo = Console.ReadLine();
            }


            Console.Write("Digite o Ano de lançamento da Série:  ");
            int entradaAno = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaAno) && entradaAno > 2021 || entradaAno < 1946)
            {
                Console.WriteLine("Data de lançamento inválida");
                Console.Write("\nDigite o Ano de lançamento da Série:  ");
            }

            Console.Write("Digite a nota do IMdB para a série entre (0 e 10) :  ");
            double entradaNota = 0.00;
            while (!double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out entradaNota) || !(entradaNota > 0 && entradaNota <= 10))
            {
                Console.WriteLine("Formato ou valor incorreto");
                Console.Write("\nDigite a nota do IMdB para a série entre (0 e 10) :  ");
            }

            Console.Write("Digite a classificação étaria: ");
            int classificacaoEtaria = 0;
            while (!int.TryParse(Console.ReadLine(), out classificacaoEtaria) || !(classificacaoEtaria >= 0 && classificacaoEtaria <= 18))
            {
                Console.WriteLine("Formato incorreto!");
                Console.WriteLine("Valor deve ser entre 0 (livre) ou 18 :  ");
            }

            Console.WriteLine("Digite a descrição da Série: ");
            string entradaDescricao = Console.ReadLine();
            while (entradaDescricao == "" || entradaDescricao == null)
            {
                Console.WriteLine("Descrição não pode ficar em branco");
                Console.WriteLine("Digite a descrição da Série: ");
                entradaDescricao = Console.ReadLine();
            }

            var id = bibliotecaSeries.ProximoId();
            Serie novaSerie = new Serie(id,
                 (Genero)entradaGenero,
                 entradaTitulo,
                 entradaDescricao,
                 entradaAno,
                 entradaNota,
                classificacaoEtaria);

            bibliotecaSeries.Inserir(novaSerie);

        }
        private static void AlterarSerie()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("ALTERAR SÉRIE");
            Console.WriteLine("---------------------- \n");
            Console.Write("Digite o ID da série: ");
            int entradaId = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaId) || (bibliotecaSeries.RetornarPorId(entradaId) == null))
            {
                Console.Write("Tipo de entrada de dados incorreta, Digite um valor númerico para o ID :   ");

            }

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            int entradaGenero = 0;
            Console.Write("Digite o Gênero entre as opções acima: ");
            while (!int.TryParse(Console.ReadLine(), out entradaGenero) || !(entradaGenero > 0 && entradaGenero <= 12))
            {
                Console.WriteLine("A opção deve ser de tipo númerico!");
                Console.Write("\nInsira um valor entre 1 e 12 :  ");
            }

            Console.Write("Digite o Título da Série : ");
            string entradaTitulo = Console.ReadLine();
            while (entradaTitulo == "" || entradaTitulo == null)
            {
                Console.WriteLine("Título não pode ficar vazio");
                Console.Write("\nDigite o Título da Série  :  ");
                entradaTitulo = Console.ReadLine();
            }

            Console.Write("Digite o Ano de lançamento da Série:  ");
            int entradaAno = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaAno) && entradaAno > 2021 || entradaAno < 1946)
            {
                Console.WriteLine("Data de lançamento inválida");
                Console.Write("\nDigite o Ano de lançamento da Série:  ");
            }

            Console.Write("Digite a nota do IMdB para a série entre (0 e 10) :  ");
            double entradaNota = 0.00;
            while (!double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out entradaNota) || !(entradaNota > 0 && entradaNota <= 10))
            {
                Console.WriteLine("Formato ou valor incorreto");
                Console.Write("\nDigite a nota do IMdB para a série entre (0 e 10) :  ");
            }

            Console.Write("Digite a classificação étaria: ");
            int classificacaoEtaria;
            while (!int.TryParse(Console.ReadLine(), out classificacaoEtaria) || !(classificacaoEtaria >= 0 && classificacaoEtaria <= 18))
            {
                Console.WriteLine("Formato incorreto!");
                Console.WriteLine("Valor deve ser entre 0 (livre) ou 18 :  ");
            }

            Console.WriteLine("Digite a descrição da Série: ");
            string entradaDescricao = Console.ReadLine();
            while (entradaDescricao == "" || entradaDescricao == null)
            {
                Console.WriteLine("Descrição não pode ficar em branco");
                Console.WriteLine("Digite a descrição da Série: ");
                entradaDescricao = Console.ReadLine();
            }

            var seriePersistido = bibliotecaSeries.RetornarPorId(entradaId);

            seriePersistido.Alterar(genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                descricao: entradaDescricao,
                ano: entradaAno,
                avaliacaoImdb: entradaNota,
                classificacaoEtaria: classificacaoEtaria);

            bibliotecaSeries.Alterar(entradaId, seriePersistido);
        }
        private static void RemoverSerie()
        {
            Console.WriteLine("Digite o ID da série");
            int entradaId = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaId) || (bibliotecaSeries.RetornarPorId(entradaId)==null))
            {
                Console.WriteLine("Entrada precisa ser númerica");
                Console.WriteLine("Não existe esse ID cadastrado:");              
            }          
            Console.WriteLine("Deseja realmente Remover? (S/N)");
            string op = Console.ReadLine().ToUpper();
            if (op == "S")
            {
                bibliotecaSeries.Excluir(entradaId);
            }
        }
        private static void ListarSeries()
        {
            Console.WriteLine("----------------------- ");
            Console.WriteLine("LISTA DE SÉRIES ");
            Console.WriteLine("----------------------- \n ");
            var series = bibliotecaSeries.Listar();
            if (series.Count == 0)
            {
                Console.WriteLine("Nenhuma Série Cadastrado");
                return;
            }

            foreach (var serie in series)
            {
                Console.WriteLine($"ID: {serie.Id} Série: {serie.Titulo}");
            }
        }
        private static void VisualizarSerie()
        {
            Console.Write("Digite o Id da Série: ");

            int indiceSerie = int.Parse(Console.ReadLine());
            var serie = bibliotecaSeries.RetornarPorId(indiceSerie);
            Console.WriteLine(serie);
        }


        //METODOS PARA FILMES
        private static void CadastrarFilme()
        {
            Console.WriteLine("----------------------- ");
            Console.WriteLine("CADASTRAR FILME");
            Console.WriteLine("-----------------------\n ");


            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.Write("Digite o número do Gênero entre as opções acima: ");
            int entradaGenero = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaGenero) || !(entradaGenero > 0 && entradaGenero <= 12))
            {
                Console.WriteLine("A opção deve ser de tipo númerico!");
                Console.Write("\nInsira um valor entre 1 e 12 :  ");
            }


            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();
            while (entradaTitulo == "" || entradaTitulo == null)
            {
                Console.WriteLine("Título não pode ficar vazio");
                Console.Write("\nDigite o Título do Filme  : ");
                entradaTitulo = Console.ReadLine();
            }


            Console.Write("Digite o Ano de lançamento do Filme:  ");
            int entradaAno = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaAno) && entradaAno > 2021 || entradaAno < 1946)
            {
                Console.WriteLine("Data de lançamento inválida");
                Console.Write("\nDigite o Ano de lançamento do Filme:  ");
            }

            Console.Write("Digite a nota do IMdB para o Filme entre (0 e 10) :  ");
            double entradaNota = 0.00;
            while (!double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out entradaNota) || !(entradaNota > 0 && entradaNota <= 10))
            {
                Console.WriteLine("Formato ou valor incorreto");
                Console.Write("\nDigite a nota do IMdB para o Filme entre (0 e 10) :  ");
            }

            Console.Write("Digite a classificação étaria: ");
            int classificacaoEtaria = 0;
            while (!int.TryParse(Console.ReadLine(), out classificacaoEtaria) || !(classificacaoEtaria >= 0 && classificacaoEtaria <= 18))
            {
                Console.WriteLine("Formato incorreto!");
                Console.WriteLine("Valor deve ser entre 0 (livre) ou 18 :  ");
            }

            Console.WriteLine("Digite a descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();
            while (entradaDescricao == "" || entradaDescricao == null)
            {
                Console.WriteLine("Descrição não pode ficar em branco");
                Console.WriteLine("Digite a descrição do Filme: ");
                entradaDescricao = Console.ReadLine();
            }

            var id = bibliotecaFilmes.ProximoId();
            Filme novoFilme = new Filme(id,
                 (Genero)entradaGenero,
                 entradaTitulo,
                 entradaDescricao,
                 entradaAno,
                 entradaNota,
                classificacaoEtaria);

            bibliotecaFilmes.Inserir(novoFilme);

        }
        private static void AlterarFilme()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("ALTERAR FILME");
            Console.WriteLine("---------------------- \n");
            Console.Write("Digite o ID do Filme: ");
            int entradaId = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaId) || (bibliotecaFilmes.RetornarPorId(entradaId) == null))
            {
                Console.Write("Tipo de entrada de dados incorreta, Digite um valor númerico para o ID :   ");

            }

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            int entradaGenero = 0;
            Console.Write("Digite o Gênero entre as opções acima: ");
            while (!int.TryParse(Console.ReadLine(), out entradaGenero) || !(entradaGenero > 0 && entradaGenero <= 12))
            {
                Console.WriteLine("A opção deve ser de tipo númerico!");
                Console.Write("\nInsira um valor entre 1 e 12 :  ");
            }

            Console.Write("Digite o Título do Filme : ");
            string entradaTitulo = Console.ReadLine();
            while (entradaTitulo == "" || entradaTitulo == null)
            {
                Console.WriteLine("Título não pode ficar vazio");
                Console.Write("\nDigite o Título do Filme  :  ");
                entradaTitulo = Console.ReadLine();
            }

            Console.Write("Digite o Ano de lançamento do Filme:  ");
            int entradaAno = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaAno) && entradaAno > 2021 || entradaAno < 1946)
            {
                Console.WriteLine("Data de lançamento inválida");
                Console.Write("\nDigite o Ano de lançamento do Filme:  ");
            }

            Console.Write("Digite a nota do IMdB para o Filme entre (0 e 10) :  ");
            double entradaNota = 0.00;
            while (!double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out entradaNota) || !(entradaNota > 0 && entradaNota <= 10))
            {
                Console.WriteLine("Formato ou valor incorreto");
                Console.Write("\nDigite a nota do IMdB para o Filme entre (0 e 10) :  ");
            }

            Console.Write("Digite a classificação étaria: ");
            int classificacaoEtaria;
            while (!int.TryParse(Console.ReadLine(), out classificacaoEtaria) || !(classificacaoEtaria >= 0 && classificacaoEtaria <= 18))
            {
                Console.WriteLine("Formato incorreto!");
                Console.WriteLine("Valor deve ser entre 0 (livre) ou 18 :  ");
            }

            Console.WriteLine("Digite a descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();
            while (entradaDescricao == "" || entradaDescricao == null)
            {
                Console.WriteLine("Descrição não pode ficar em branco");
                Console.WriteLine("Digite a descrição do Filme: ");
                entradaDescricao = Console.ReadLine();
            }

            var filmePersistido = bibliotecaFilmes.RetornarPorId(entradaId);

            filmePersistido.Alterar(genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                descricao: entradaDescricao,
                ano: entradaAno,
                avaliacaoImdb: entradaNota,
                classificacaoEtaria: classificacaoEtaria);

            bibliotecaFilmes.Alterar(entradaId, filmePersistido);
        }
        private static void RemoverFilme()
        {
            Console.WriteLine("Digite o ID do Filme");
            int entradaId = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaId) || (bibliotecaFilmes.RetornarPorId(entradaId) == null))
            {
                Console.WriteLine("Entrada precisa ser númerica");
                Console.WriteLine("Não existe esse ID cadastrado:");
            }
            Console.WriteLine("Deseja realmente Remover? (S/N)");
            string op = Console.ReadLine().ToUpper();
            if (op == "S")
            {
                bibliotecaFilmes.Excluir(entradaId);
            }
        }
        private static void ListarFilmes()
        {
            Console.WriteLine("----------------------- ");
            Console.WriteLine("LISTA DE FILMES ");
            Console.WriteLine("----------------------- \n ");
            var filmes = bibliotecaFilmes.Listar();
            if (filmes.Count == 0)
            {
                Console.WriteLine("Nenhum Filme Cadastrado");
                return;
            }

            foreach (var filme in filmes)
            {
                Console.WriteLine($"ID: {filme.Id} Filme: {filme.Titulo}");
            }
        }
        private static void VisualizarFilme()
        {
            Console.Write("Digite o Id do Filme: ");

            int indiceFilmes = int.Parse(Console.ReadLine());
            var filmes = bibliotecaFilmes.RetornarPorId(indiceFilmes);
            Console.WriteLine(filmes);
        }
        //METODOS PARA DOCUMENTARIOS

        private static void CadastrarDocumentario()
        {
            Console.WriteLine("----------------------- ");
            Console.WriteLine("CADASTRAR DOCUMENTÁRIO");
            Console.WriteLine("-----------------------\n ");


            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.Write("Digite o número do Gênero entre as opções acima: ");
            int entradaGenero = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaGenero) || !(entradaGenero > 0 && entradaGenero <= 12))
            {
                Console.WriteLine("A opção deve ser de tipo númerico!");
                Console.Write("\nInsira um valor entre 1 e 12 :  ");
            }


            Console.Write("Digite o Título do Documentário: ");
            string entradaTitulo = Console.ReadLine();
            while (entradaTitulo == "" || entradaTitulo == null)
            {
                Console.WriteLine("Título não pode ficar vazio");
                Console.Write("\nDigite o Título do Documentário  : ");
                entradaTitulo = Console.ReadLine();
            }


            Console.Write("Digite o Ano de lançamento do Documentário:  ");
            int entradaAno = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaAno) && entradaAno > 2021 || entradaAno < 1946)
            {
                Console.WriteLine("Data de lançamento inválida");
                Console.Write("\nDigite o Ano de lançamento do Documentário:  ");
            }

            Console.Write("Digite a nota do IMdB para o Documentário entre (0 e 10) :  ");
            double entradaNota = 0.00;
            while (!double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out entradaNota) || !(entradaNota > 0 && entradaNota <= 10))
            {
                Console.WriteLine("Formato ou valor incorreto");
                Console.Write("\nDigite a nota do IMdB para o Documentário entre (0 e 10) :  ");
            }

            Console.Write("Digite a classificação étaria: ");
            int classificacaoEtaria = 0;
            while (!int.TryParse(Console.ReadLine(), out classificacaoEtaria) || !(classificacaoEtaria >= 0 && classificacaoEtaria <= 18))
            {
                Console.WriteLine("Formato incorreto!");
                Console.WriteLine("Valor deve ser entre 0 (livre) ou 18 :  ");
            }

            Console.WriteLine("Digite a descrição do Documentário: ");
            string entradaDescricao = Console.ReadLine();
            while (entradaDescricao == "" || entradaDescricao == null)
            {
                Console.WriteLine("Descrição não pode ficar em branco");
                Console.WriteLine("Digite a descrição do Documentário: ");
                entradaDescricao = Console.ReadLine();
            }

            var id = bibliotecaDocumentarios.ProximoId();
            Documentario novoDocumentario = new Documentario(id,
                 (Genero)entradaGenero,
                 entradaTitulo,
                 entradaDescricao,
                 entradaAno,
                 entradaNota,
                classificacaoEtaria);

            bibliotecaDocumentarios.Inserir(novoDocumentario);

        }
        private static void AlterarDocumentario()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("ALTERAR DOCUMENTÁRIO");
            Console.WriteLine("---------------------- \n");
            Console.Write("Digite o ID do Documentário: ");
            int entradaId = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaId) || (bibliotecaDocumentarios.RetornarPorId(entradaId) == null))
            {
                Console.Write("Tipo de entrada de dados incorreta, Digite um valor númerico para o ID :   ");

            }

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            int entradaGenero = 0;
            Console.Write("Digite o Gênero entre as opções acima: ");
            while (!int.TryParse(Console.ReadLine(), out entradaGenero) || !(entradaGenero > 0 && entradaGenero <= 12))
            {
                Console.WriteLine("A opção deve ser de tipo númerico!");
                Console.Write("\nInsira um valor entre 1 e 12 :  ");
            }

            Console.Write("Digite o Título do Documentário : ");
            string entradaTitulo = Console.ReadLine();
            while (entradaTitulo == "" || entradaTitulo == null)
            {
                Console.WriteLine("Título não pode ficar vazio");
                Console.Write("\nDigite o Título do Documentário  :  ");
                entradaTitulo = Console.ReadLine();
            }

            Console.Write("Digite o Ano de lançamento do Documentário:  ");
            int entradaAno = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaAno) && entradaAno > 2021 || entradaAno < 1946)
            {
                Console.WriteLine("Data de lançamento inválida");
                Console.Write("\nDigite o Ano de lançamento do Documentário:  ");
            }

            Console.Write("Digite a nota do IMdB para o Documentário entre (0 e 10) :  ");
            double entradaNota = 0.00;
            while (!double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out entradaNota) || !(entradaNota > 0 && entradaNota <= 10))
            {
                Console.WriteLine("Formato ou valor incorreto");
                Console.Write("\nDigite a nota do IMdB para o Documentário entre (0 e 10) :  ");
            }

            Console.Write("Digite a classificação étaria: ");
            int classificacaoEtaria;
            while (!int.TryParse(Console.ReadLine(), out classificacaoEtaria) || !(classificacaoEtaria >= 0 && classificacaoEtaria <= 18))
            {
                Console.WriteLine("Formato incorreto!");
                Console.WriteLine("Valor deve ser entre 0 (livre) ou 18 :  ");
            }

            Console.WriteLine("Digite a descrição do Documentário: ");
            string entradaDescricao = Console.ReadLine();
            while (entradaDescricao == "" || entradaDescricao == null)
            {
                Console.WriteLine("Descrição não pode ficar em branco");
                Console.WriteLine("Digite a descrição do Documentário: ");
                entradaDescricao = Console.ReadLine();
            }

            var documentarioPersistido = bibliotecaDocumentarios.RetornarPorId(entradaId);

            documentarioPersistido.Alterar(genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                descricao: entradaDescricao,
                ano: entradaAno,
                avaliacaoImdb: entradaNota,
                classificacaoEtaria: classificacaoEtaria);

            bibliotecaDocumentarios.Alterar(entradaId, documentarioPersistido);
        }
        private static void RemoverDocumentario()
        {
            Console.WriteLine("Digite o ID do Documentário");
            int entradaId = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaId) || (bibliotecaDocumentarios.RetornarPorId(entradaId) == null))
            {
                Console.WriteLine("Entrada precisa ser númerica");
                Console.WriteLine("Não existe esse ID cadastrado:");
            }
            Console.WriteLine("Deseja realmente Remover? (S/N)");
            string op = Console.ReadLine().ToUpper();
            if (op == "S")
            {
                bibliotecaDocumentarios.Excluir(entradaId);
            }
        }
        private static void ListarDocumentarios()
        {
            Console.WriteLine("----------------------- ");
            Console.WriteLine("LISTA DE DOCUMENTÁRIOS ");
            Console.WriteLine("----------------------- \n ");
            var documentarios = bibliotecaDocumentarios.Listar();
            if (documentarios.Count == 0)
            {
                Console.WriteLine("Nenhum Documentário Cadastrado");
                return;
            }

            foreach (var documentario in documentarios)
            {
                Console.WriteLine($"ID: {documentario.Id} Documentário: {documentario.Titulo}");
            }
        }
        private static void VisualizarDocumentario()
        {
            Console.Write("Digite o Id do Documentário: ");

            int indiceDocumentarios = int.Parse(Console.ReadLine());
            var documentarios = bibliotecaDocumentarios.RetornarPorId(indiceDocumentarios);
            Console.WriteLine(documentarios);
        }


        //METODOS PARA ANIMES



        private static void CadastrarAnime()
        {
            Console.WriteLine("----------------------- ");
            Console.WriteLine("CADASTRAR ANIME");
            Console.WriteLine("-----------------------\n ");


            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.Write("Digite o número do Gênero entre as opções acima: ");
            int entradaGenero = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaGenero) || !(entradaGenero > 0 && entradaGenero <= 12))
            {
                Console.WriteLine("A opção deve ser de tipo númerico!");
                Console.Write("\nInsira um valor entre 1 e 12 :  ");
            }


            Console.Write("Digite o Título do Anime: ");
            string entradaTitulo = Console.ReadLine();
            while (entradaTitulo == "" || entradaTitulo == null)
            {
                Console.WriteLine("Título não pode ficar vazio");
                Console.Write("\nDigite o Título do Anime  : ");
                entradaTitulo = Console.ReadLine();
            }


            Console.Write("Digite o Ano de lançamento do Anime:  ");
            int entradaAno = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaAno) && entradaAno > 2021 || entradaAno < 1946)
            {
                Console.WriteLine("Data de lançamento inválida");
                Console.Write("\nDigite o Ano de lançamento do Anime:  ");
            }

            Console.Write("Digite a nota do IMdB para o Anime entre (0 e 10) :  ");
            double entradaNota = 0.00;
            while (!double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out entradaNota) || !(entradaNota > 0 && entradaNota <= 10))
            {
                Console.WriteLine("Formato ou valor incorreto");
                Console.Write("\nDigite a nota do IMdB para o Anime entre (0 e 10) :  ");
            }

            Console.Write("Digite a classificação étaria: ");
            int classificacaoEtaria = 0;
            while (!int.TryParse(Console.ReadLine(), out classificacaoEtaria) || !(classificacaoEtaria >= 0 && classificacaoEtaria <= 18))
            {
                Console.WriteLine("Formato incorreto!");
                Console.WriteLine("Valor deve ser entre 0 (livre) ou 18 :  ");
            }

            Console.WriteLine("Digite a descrição do Anime: ");
            string entradaDescricao = Console.ReadLine();
            while (entradaDescricao == "" || entradaDescricao == null)
            {
                Console.WriteLine("Descrição não pode ficar em branco");
                Console.WriteLine("Digite a descrição do Anime: ");
                entradaDescricao = Console.ReadLine();
            }

            var id = bibliotecaAnimes.ProximoId();
            Anime novoAnime = new Anime(id,
                 (Genero)entradaGenero,
                 entradaTitulo,
                 entradaDescricao,
                 entradaAno,
                 entradaNota,
                classificacaoEtaria);

            bibliotecaAnimes.Inserir(novoAnime);

        }
        private static void AlterarAnime()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("ALTERAR ANIME");
            Console.WriteLine("---------------------- \n");
            Console.Write("Digite o ID do Anime: ");
            int entradaId = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaId) || (bibliotecaAnimes.RetornarPorId(entradaId) == null))
            {
                Console.Write("Tipo de entrada de dados incorreta, Digite um valor númerico para o ID :   ");

            }

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            int entradaGenero = 0;
            Console.Write("Digite o Gênero entre as opções acima: ");
            while (!int.TryParse(Console.ReadLine(), out entradaGenero) || !(entradaGenero > 0 && entradaGenero <= 12))
            {
                Console.WriteLine("A opção deve ser de tipo númerico!");
                Console.Write("\nInsira um valor entre 1 e 12 :  ");
            }

            Console.Write("Digite o Título do Anime : ");
            string entradaTitulo = Console.ReadLine();
            while (entradaTitulo == "" || entradaTitulo == null)
            {
                Console.WriteLine("Título não pode ficar vazio");
                Console.Write("\nDigite o Título do Anime  :  ");
                entradaTitulo = Console.ReadLine();
            }

            Console.Write("Digite o Ano de lançamento do Anime:  ");
            int entradaAno = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaAno) && entradaAno > 2021 || entradaAno < 1946)
            {
                Console.WriteLine("Data de lançamento inválida");
                Console.Write("\nDigite o Ano de lançamento do Anime:  ");
            }

            Console.Write("Digite a nota do IMdB para o Anime entre (0 e 10) :  ");
            double entradaNota = 0.00;
            while (!double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out entradaNota) || !(entradaNota > 0 && entradaNota <= 10))
            {
                Console.WriteLine("Formato ou valor incorreto");
                Console.Write("\nDigite a nota do IMdB para o Anime entre (0 e 10) :  ");
            }

            Console.Write("Digite a classificação étaria: ");
            int classificacaoEtaria;
            while (!int.TryParse(Console.ReadLine(), out classificacaoEtaria) || !(classificacaoEtaria >= 0 && classificacaoEtaria <= 18))
            {
                Console.WriteLine("Formato incorreto!");
                Console.WriteLine("Valor deve ser entre 0 (livre) ou 18 :  ");
            }

            Console.WriteLine("Digite a descrição do Anime: ");
            string entradaDescricao = Console.ReadLine();
            while (entradaDescricao == "" || entradaDescricao == null)
            {
                Console.WriteLine("Descrição não pode ficar em branco");
                Console.WriteLine("Digite a descrição do Anime: ");
                entradaDescricao = Console.ReadLine();
            }

            var animePersistido = bibliotecaAnimes.RetornarPorId(entradaId);

            animePersistido.Alterar(genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                descricao: entradaDescricao,
                ano: entradaAno,
                avaliacaoImdb: entradaNota,
                classificacaoEtaria: classificacaoEtaria);

            bibliotecaAnimes.Alterar(entradaId, animePersistido);
        }
        private static void RemoverAnime()
        {
            Console.WriteLine("Digite o ID do Anime");
            int entradaId = 0;
            while (!int.TryParse(Console.ReadLine(), out entradaId) || (bibliotecaAnimes.RetornarPorId(entradaId) == null))
            {
                Console.WriteLine("Entrada precisa ser númerica");
                Console.WriteLine("Não existe esse ID cadastrado:");
            }
            Console.WriteLine("Deseja realmente Remover? (S/N)");
            string op = Console.ReadLine().ToUpper();
            if (op == "S")
            {
                bibliotecaAnimes.Excluir(entradaId);
            }
        }
        private static void ListarAnimes()
        {
            Console.WriteLine("----------------------- ");
            Console.WriteLine("LISTA DE ANIMES ");
            Console.WriteLine("----------------------- \n ");
            var animes = bibliotecaAnimes.Listar();
            if (animes.Count == 0)
            {
                Console.WriteLine("Nenhum Anime Cadastrado");
                return;
            }

            foreach (var anime in animes)
            {
                Console.WriteLine($"ID: {anime.Id} Anime: {anime.Titulo}");
            }
        }
        private static void VisualizarAnime()
        {
            Console.Write("Digite o Id do Anime: ");

            int indiceAnimes = int.Parse(Console.ReadLine());
            var animes = bibliotecaAnimes.RetornarPorId(indiceAnimes);
            Console.WriteLine(animes);
        }

        private static string MenuPrincipal()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n BIBLIOTECA DIO TELA INICIAL \n");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Informe a opção desejada \n");
            Console.WriteLine("1 - Para Opções sobre Séries: ");
            Console.WriteLine("2 - Para Opções sobre Filmes: ");
            Console.WriteLine("3 - Para Opções sobre Documentários: ");
            Console.WriteLine("4 - Para Opções sobre Animes: ");
            Console.WriteLine("5 - Fechar Programa");

            string opcaoMenuPrincipal = Console.ReadLine();
            Console.WriteLine();
            return opcaoMenuPrincipal;
        }
        private static string MenuSeries()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Opções Séries: ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1 - Cadastrar nova Série");
            Console.WriteLine("2 - Alterar Série");
            Console.WriteLine("3 - Remover Série");
            Console.WriteLine("4 - Listar todas Séries");
            Console.WriteLine("5 - Visualizar Serie");
            Console.WriteLine("6 - Voltar para Menu Principal");

            string opcaoSerie = Console.ReadLine();
            Console.WriteLine();
            return opcaoSerie;
        }
        private static object MenuFilmes()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Opções Filmes: ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1 - Cadastrar novo Filme");
            Console.WriteLine("2 - Alterar Filmes");
            Console.WriteLine("3 - Remover Filmes");
            Console.WriteLine("4 - Listar todos Filmes");
            Console.WriteLine("5 - Visualizar Filme");
            Console.WriteLine("6 - Voltar para Menu Principal");

            string opcaoFilme = Console.ReadLine();
            Console.WriteLine();
            return opcaoFilme;
        }
        private static object MenuDocumentarios()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Opções Documentários: ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1 - Cadastrar novo Documentário");
            Console.WriteLine("2 - Alterar Documentário");
            Console.WriteLine("3 - Remover Documentário");
            Console.WriteLine("4 - Listar todos Documentários");
            Console.WriteLine("5 - Visualizar Documentário");
            Console.WriteLine("6 - Voltar para Menu Principal");

            string opcaoDocumentario = Console.ReadLine();
            Console.WriteLine();
            return opcaoDocumentario;
        }
        private static object MenuAnimes()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Opções Animes: ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1 - Cadastrar novo Anime");
            Console.WriteLine("2 - Alterar Anime");
            Console.WriteLine("3 - Remover Anime");
            Console.WriteLine("4 - Listar todos Animes");
            Console.WriteLine("5 - Visualizar Anime");
            Console.WriteLine("6 - Voltar para Menu Principal");

            string opcaoAnime = Console.ReadLine();
            Console.WriteLine();
            return opcaoAnime;
        }
    }
}