<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listagem.aspx.cs" Inherits="WebVehicles.listagem" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE HTML>
<html>
<head>
    <title>WebVehicles</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <link href="/css/bootstrap.min.css" rel="stylesheet">
    <link href="/css/bootstrap-material-design.min.css" rel="stylesheet">

    <link href='http://fonts.googleapis.com/css?family=Lato:100,300,400,700,900' rel='stylesheet' type='text/css'>
    <link href="/css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link href="/css/owl.carousel.css" rel="stylesheet">
    <link href="/css/font-awesome.min.css" rel="stylesheet">
    <link rel="stylesheet" type="text/css" href="/css/magnific-popup.css">



    <link rel="stylesheet" type="text/css" href="/css/magnific-popup.css">
    <script type="text/javascript" src="/js/jquery.min.js"></script>
    <script src="/js/owl.carousel.js"></script>
    <!-- //Owl Carousel Assets -->
    <!-----768px-menu----->
    <link type="text/css" rel="stylesheet" href="/css/jquery.mmenu.all.css" />

    <script type="text/javascript" src="/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="/js/material.min.js"></script>
    <script type="text/javascript" src="/js/ripples.min.js"></script>
    <script type="text/javascript" src="/js/jquery.mmenu.js"></script>
    <script type="text/javascript">
        //	The menu on the left
        $(function () {
            $('nav#menu-left').mmenu();
        });
    </script>
    <style type="text/css">
        label {
            color: #000 !important;
        }
    </style>
    <!-----//768px-menu----->
</head>
<body>
    <form id="form1" runat="server">
    <!-- start header -->
    <div class="header_bg">
        <div class="wrap">
            <div class="header">
                <div class="logo">
                    <a href="index.html">
                        <img src="/images/lg.png" alt="" />
                        <h1>WebVehicles</h1>
                        <div class="clear"></div>
                    </a>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </div>
    <!-- start header -->

    <div class="testimonial">
        <!-- start last_posts -->
        <div class="wrap">
            <h5 class="heading">LISTAGEM DE carroS</h5>
            <div class="test-grids">
                <div class="row">
                    <div class="col-md-8" style="float: none; margin: 0 auto;">
                        <div class="row" style="margin: 0px 0px 0px 15px;">
                            
                            <asp:GridView ID="GridView1" runat="server">
                            </asp:GridView>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
    <div class="footer">
        <div class="wrap">
            <div class="footer-left" style="width: 100%; text-align: justify;">
                <h3>Quem somos</h3>
                <p>Criada em 1995, no início da internet brasileira, a WebMotors conquistou ao longo do tempo o posto de maior portal brasileiro no segmento automobilístico (Ibope Net View junho/2013).</p>

                <p>Em 2002, a WebMotors foi adquirida pelo ABN AMRO, e agora pertence ao Grupo Santander Brasil, um dos maiores bancos do mundo, e grande fomentador do mercado de automóveis no Brasil através de sua financeira, Santander Financiamentos.</p>

                <p>A WebMotors oferece aos seus usuários e clientes a oportunidade de usufruir da sua elevada e comprovada audiência, utilizando-se de produtos e serviços altamente eficientes.</p>

                <p>Na WebMotors são disponibilizados classificados para venda de veículos – com mais de 200 mil ofertas por mês –, programas de manutenção preventiva veicular e produtos específicos direcionados especialmente às Revendas de Veículos e empresas atuantes no segmento automobilístico, como fabricantes de veículos e autopeças, e outras empresas que atuam nesse segmento.</p>

                <p>A WebMotors também disponibiliza aos internautas vasto conteúdo editorial, como testes, comparativos, guia de compra, lançamentos e segredos; comportamento, bem-estar no trânsito e notícias de mercado. Conta também com colaboradores renomados e especializados no mundo do automóvel.</p>

                <p>Além disso, a WebMotors investe em tecnologia de ponta continuamente para manter a segurança dos dados e a sua privacidade durante toda a navegação. Usando as mais novas ferramentas, tecnologias e métodos disponíveis, a WebMotors garante disponibilidade e performance adequada para que sua experiência de navegação seja rápida e agradável.</p>

                <p>Faça um test-drive agora mesmo no maior e mais completo site de veículos da internet brasileira.</p>

            </div>
            <div class="clear"></div>
        </div>
    </div>
    <div class="copy">
        <%--<p>© <%= ""+DateTime.Now.Year %>Desenvolvido por <a href="https://www.linkedin.com/in/higor-manoel-lima-correa-080b3bb2" target="_blank">Higor Correa</a></p>--%>
    </div>
    
    </form>
    
</body>
</html>
