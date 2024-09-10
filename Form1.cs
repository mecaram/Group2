﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelLibros_submenu.Visible = false;
            panelEnciclopedias_submenu.Visible = false;
            panelDiccionarios_submenu.Visible = false;
            panelMapas_submenu.Visible = false;
            panelProyectos_submenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelLibros_submenu.Visible == true)
                panelLibros_submenu.Visible = false;
            if (panelEnciclopedias_submenu.Visible == true)
                panelEnciclopedias_submenu.Visible = false;
            if (panelDiccionarios_submenu.Visible == true)
                panelDiccionarios_submenu.Visible = false;
            if (panelMapas_submenu.Visible == true)
                panelMapas_submenu.Visible = false;
            if (panelProyectos_submenu.Visible == true)
                panelProyectos_submenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }   

        private void btnDespLibros_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelLibros_submenu);
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnTemas_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnEditorial_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnNivel_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnEnciclopedias_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEnciclopedias_submenu);

        }

        private void btnEditorialCiclo_Click_1(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnTemasCiclo_Click_1(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnDiccionarios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDiccionarios_submenu);
        }

        private void btnEditorialDiccio_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnMapas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMapas_submenu);
        }

        private void btnTemasMap_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnEditorialMap_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProyectos_submenu);
        }

        private void btnCarrera_Click_1(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnJuegos_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTesis_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDispositivos_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSideView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistross_Click(object sender, EventArgs e)
        {

        }

        private void panelLibros_submenus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
