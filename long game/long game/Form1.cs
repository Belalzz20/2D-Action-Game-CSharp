using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace long_game
{
    public partial class Form1 : Form
    {
        int flage = 1;
        bool flagelevel2 = false;
        Random r = new Random();
        int dir = 0;
        Bitmap off_image;
        actor part2 = new actor();
        actor part3 = new actor();
        actor part4 = new actor();
        Bitmap back1 = new Bitmap("back1.jpg");
        Bitmap back2 = new Bitmap("back2.jpg");
        Bitmap back3 = new Bitmap("back3.jpg");
        List<Bitmap> poshero = new List<Bitmap>();
        List<Bitmap> enamy1 = new List<Bitmap>();
        List<Bitmap> polit = new List<Bitmap>();
        List<Bitmap> enamy2 = new List<Bitmap>();
        List<Bitmap> enamy3 = new List<Bitmap>();
        List<Bitmap> arroow = new List<Bitmap>();
        List<Bitmap> elvetor = new List<Bitmap>();
        List<enamy> plane = new List<enamy>();
        List<enamy2> ename = new List<enamy2>();
        List<enamy3> ename3 = new List<enamy3>();
        List<Shot> shots = new List<Shot>();
        List<arrow> Arrow = new List<arrow>();
        List<boss> Boss = new List<boss>();
        bool heroAttachedToElevator = false;
        bool isJumping = false;
        int jumpHeight = 110;
        int jumpSpeed = 17;
        int moveForwardSpeed = 6;
        bool jumpingBackward = false;
        bool jumpingForward = false;
        bool isSpacePressed = false;
        bool isRightPressed = false;
        bool isLeftPressed = false;
        int initialYHero;
        int location = 2;

        bool isOnElevator = false;
        bool elevatorMoving = false;
        int elevatorY = 600;
        int elevatorSpeed = 5;

        Timer T = new Timer();
        int pos = 0, xhero, yhero, side;
        int pos2 = 0;
        int pos3 = 0;
        int xenamy1;
        int yenamy1;
        int xenamy2;
        int yenamy2;
        int Timer = 60;
        int counter = 0;

        int Timer2 = 40;
        int counter2 = 0;

        int shotTimer = 50;
        int shotCounter = 0;
        int fireTimer = 25;
        int fireCounter = 0;

        int fireTimer2 = 50;
        int fireCounter2 = 0;

        int shotTimer2 = 50;
        int shotCounter2 = 0;

        int shotTimer3 = 70;
        int shotCounter3 = 0;

       
        // //  //   //
        Bitmap h = new Bitmap("heart.png");
        List<heart> hearts = new List<heart>();
        Bitmap Restart = new Bitmap("Restart.png");
        int xrestart = 0;
        int yrestart = 0;
        bool wait = false;

        int space = 30;
        int counter1 = 0;
        int score = 0;
        Bitmap level1 = new Bitmap("level1.png");
        Bitmap level2 = new Bitmap("level2.png");
        Bitmap level3 = new Bitmap("level3.png");
        Bitmap boulet1 = new Bitmap("boulet.png");
        Bitmap boulet2 = new Bitmap("bullet2.png");
        Bitmap enemy1 = new Bitmap("enemy.png");
        List<enemy> n = new List<enemy>();
        List<boulet> boll = new List<boulet>();
        List<boulet> boll2 = new List<boulet>();
        List<boulet> boll3 = new List<boulet>();
        int xplan1 = 50, yplan1 = 100;
        int xplan2 = 50, yplan2 = 100;
        int xplan3 = 50, yplan3 = 100;
        int xenemy1, yenemy1;
        int flagboll = 0;
        int slinex, sliney, elinex, eliney;
        int flagboll2 = 0;
        int flagline = 0;
        int on = 1;
        int off = 0;
        int countx = 0;
        int xpos, ypos;
        Bitmap po = new Bitmap("pos1.png");


        List<coin> coins = new List<coin>();
        Bitmap steps = new Bitmap("staircase.png");
        Bitmap down = new Bitmap("downcoin.png");
        int xsteps, ysteps, hsteps, wsteps;
        int xdowncoin, ydowncoin;
        int poscoin = 0;
        Bitmap Queen = new Bitmap("Queen.png");
        Bitmap fireball = new Bitmap("fireball.png");
        Bitmap fireboos = new Bitmap("fireshoot.png");
        List<fire> ff = new List<fire>();
        List<fireboos> ff1 = new List<fireboos>();
        List<Bitmap> c = new List<Bitmap>();
        int xqueen, yqueen;
        int flage_final_level = 0;
        List<health> healths = new List<health>();
        List<Bitmap> hh2 = new List<Bitmap>();
        int xhealth, yhealth,whealth,hhealth;
        int poshealth=0;

        List<diehero> die = new List<diehero>();//belal 555555
        List<Bitmap> dieh = new List<Bitmap>();//belal 5555555
        int flagdie = 0;///55555
        int diepos = 0;//5555
        int diespace = 10;///5555
        int diect = 0;///555
        Bitmap gameover = new Bitmap("gameover.jpg");//belal 555555
        Bitmap win = new Bitmap("win.jpg");//belal 555555
        int ctplan = 0;
        int flagwin = 0;



        int ctpoos = 0;

        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.Paint += Form1_Paint;
            xhero = 0;
            yhero = 600;
            yqueen = yhero-50;
            xqueen = this.ClientSize.Width +200;
            xsteps = 100;
            ysteps = 400;
            wsteps = 400;
            hsteps = 300;

            xpos = xqueen - 300; 
            ypos = yqueen- 100;

            boss pnn = new boss();
            pnn.xboss = xqueen - 300;
            pnn.yboss = yqueen - 100;
            Boss.Add(pnn);


            xhealth = xpos+50;
            yhealth = ypos-50;
            whealth = 200;
            hhealth = 50;

                
            xdowncoin = xsteps;
            ydowncoin = ysteps;
            int tt = this.Width;
            this.Load += Form1_Load;
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
            T.Start();
            T.Tick += T_Tick;

            for (int i = 1; i <= 3; i++)
            {
                Bitmap m = new Bitmap("die" + i.ToString() + ".png");
                m.MakeTransparent();
                dieh.Add(m);

            }
            for (int i = 1; i <= 4; i++)
            {
                Bitmap b = new Bitmap(i.ToString() + ".png");
                b.MakeTransparent();
                poshero.Add(b);
            }
            for (int i = 1; i <= 5; i++)
            {
                Bitmap e = new Bitmap("c" + i.ToString() + ".png");
                e.MakeTransparent();
                c.Add(e);

            }
            for (int i = 1; i <= 4; i++)
            {
                Bitmap b = new Bitmap("health"+i.ToString() + ".png");
                b.MakeTransparent();
                hh2.Add(b);
            }
            for (int i = 0; i < 2; i++)
            {
                Bitmap e = new Bitmap("plane" + i.ToString() + ".jpg");
                e.MakeTransparent();
                enamy1.Add(e);
            }
       

            Bitmap p = new Bitmap("polit.png");
            p.MakeTransparent();
            polit.Add(p);
            for (int i = 0; i <= 6; i++)
            {
                Bitmap e2 = new Bitmap("E" + i.ToString() + ".png");
                e2.MakeTransparent();
                enamy2.Add(e2);
            }
            for (int i = 1; i <5; i++)
            {
                Bitmap e3 = new Bitmap("Ee" + i.ToString() + ".png");
                e3.MakeTransparent();
                enamy3.Add(e3);
            }

            Bitmap g = new Bitmap("elvetor.png");
            g.MakeTransparent();
            elvetor.Add(g);

            Bitmap A = new Bitmap("Arrow.png");
            A.MakeTransparent();
            arroow.Add(A);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                isLeftPressed = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                isRightPressed = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                isSpacePressed = false;
            }
            if (e.KeyCode == Keys.W)
            {
                wait = false;
            }
        }

        private void T_Tick(object sender, EventArgs e)
        {
           

            if (hearts.Count == 0)//55555555
            {
                flagdie = 1;
                if (diect == 5)
                {
                    diepos++;
                }
                if (diect == 10)
                {
                    diepos++;
                }
                if (diect == 15)
                {
                    diepos++;
                    flagelevel2 = false;
                }
                diect++;


            }////////55555555

            poscoin++;
            if (poscoin == 5)
            {
                poscoin = 0;
            }

            ////healthh///

            if (slinex+400 >= xpos && slinex <= xpos+300)
            {
                if (sliney >= ypos && sliney <= ypos+300)
                {
                    ctpoos++;
                    if (ctpoos==1)
                    {
                        poshealth++;
                    }
                    if (ctpoos == 2)
                    {
                        poshealth++;
                    }


                    if (ctpoos == 3)
                    {
                        poshealth++;
                    }

                    if (ctpoos == 4)
                    {
                        poshealth++;
                        flagline = 2;
                        
                    }
                    if (ctpoos == 5)
                    {
                        poshealth = 3;
                        Boss.Clear();
                        hh2.Clear();
                       

                    }




                }
            }


            for (int i = 0; i < plane.Count; i++)
            {
                if (plane[i].isMovingRight)
                {
                    side = 1;
                    plane[i].xe += 10;
                    if (plane[i].xe + 150 >= this.ClientSize.Width)
                    {
                        plane[i].isMovingRight = false;
                    }
                }
                else
                {
                    side = 0;
                    plane[i].xe -= 10;
                    if (plane[i].xe <= 0)
                    {
                        plane[i].isMovingRight = true;
                    }
                }

            }
            if (flage == 2)
            {
                shotCounter++;
                if (shotCounter == shotTimer)
                {
                    for (int i = 0; i < plane.Count; i++)
                    {
                        Shot newShot = new Shot();
                        newShot.xs = plane[i].xe + 75;
                        newShot.ys = plane[i].ye + 150;
                        shots.Add(newShot);
                        if (score == 8)
                        {
                            shots.Clear();
                            shotTimer = -1;
                        }
                    }
                    shotCounter = 0;
                }
                for (int i = 0; i < shots.Count; i++)
                {
                    shots[i].ys += 10;

                }

                counter++;
                if (counter == Timer)
                {
                    enamy2 pnn = new enamy2();
                    pnn.xenemy2 = this.Width + 100;
                    pnn.yenemy2 = 600;
                    ename.Add(pnn);
                    counter = 0;
                    if (score == 8)
                    {
                        ename.Clear();

                        Timer = -1;
                    }
                }
                for (int i = 0; i < ename.Count; i++)
                {
                    pos2++;
                    ename[i].xenemy2 -= 10;
                    if (pos2 == 6)
                    {
                        pos2 = 0;
                    }
                }

                shotCounter2++;
                if (shotCounter2 == shotTimer2)
                {


                    for (int i = 0; i < ename.Count; i++)
                    {
                        ename[i].xenemy2 -= 10;
                        arrow newArrow = new arrow();
                        newArrow.xarrow = ename[i].xenemy2;
                        newArrow.yarrow = ename[i].yenemy2 + 15;
                        Arrow.Add(newArrow);
                        if (score == 8)
                        {
                            Arrow.Clear();

                            shotTimer2 = -1;
                        }

                    }
                    shotCounter2 = 0;
                }

            }
            if (flage == 3)      //  // // // final level
            {
                if(xhero >xqueen)
                {
                    flagwin = 1;
                }
                xplan3 += 20;
                counter2++;
                if (counter2 == Timer2)
                {
                    enamy3 pnn = new enamy3();
                    pnn.xenemy3 = this.Width + 100;
                    pnn.yenemy3 = 600;
                    ename3.Add(pnn);
                    if(score ==12)
                    {
                        Timer2 = -1;
                        ename3.Clear();

                    }
                    counter2 = 0;
                }
                for (int i = 0; i < ename3.Count; i++)
                {
                    pos3++;
                    ename3[i].xenemy3 -= 10;
                    if (pos3 == 4)
                    {
                        pos3 = 0;
                    }
                }


                shotCounter3++;
                if (shotCounter3 == shotTimer3)
                {
                    for (int i = 0; i < ename3.Count; i++)
                    {
                        ename3[i].xenemy3 -= 10;
                        boulet newshoot3 = new boulet();
                        newshoot3.xboulet3 = ename3[i].xenemy3;
                        newshoot3.yboulet3 = ename3[i].yenemy3 + 25;
                        boll3.Add(newshoot3);
                        if (score ==12)
                        {
                            shotTimer3 = -1;
                            boll3.Clear();

                        }


                    }
                    shotCounter3 = 0;
                }

                fireCounter++;
                if (fireCounter == fireTimer)
                {
                    fire pnn = new fire();
                    pnn.xfire = r.Next(100, this.ClientSize.Width - 100);
                    pnn.yfire = r.Next(-75, -25);
                    ff.Add(pnn);
                    fireCounter = 0;
                    
                }
                for (int i = 0; i < ff.Count; i++)
                {
                    ff[i].yfire += 35;
                }
                for (int i = 0; i < boll3.Count; i++)
                {
                    boll3[i].xboulet3 -= 30;
                }
                if (flage_final_level == 1)
                {
                    fireCounter2++;
                    if (fireCounter2 == fireTimer2)
                    {
                        for (int i = 0; i < Boss.Count; i++)
                        {
                            fireboos pnn = new fireboos();
                            pnn.xfireboos = Boss[i].xboss;
                            pnn.yfireboos = Boss[i].yboss + 50;
                            ff1.Add(pnn);
                        }

                        fireCounter2 = 0;
                    }
                    for (int i = 0; i < ff1.Count; i++)
                    {
                        ff1[i].xfireboos -= 15;
                    }
                }
            }

            for (int i = 0; i < Arrow.Count; i++)
            {
                Arrow[i].xarrow -= 30;
            }
            if (wait == false)
            {
                if (heroAttachedToElevator == false)
                {
                    if (isJumping)
                    {
                        yhero -= jumpSpeed;
                        if (jumpingBackward == true)
                        {
                            xhero -= moveForwardSpeed;
                        }
                        else if (jumpingForward == true)
                        {
                            xhero += moveForwardSpeed;
                        }


                        if (yhero <= initialYHero - jumpHeight)
                        {
                            isJumping = false;
                        }
                    }
                    else if (yhero < initialYHero)
                    {
                        yhero += 17;
                        if (jumpingBackward == true)
                        {
                            xhero -= 7;
                        }
                        else if (jumpingForward == true)
                        {
                            xhero += 7;
                        }
                    }
                }
            }
           
            for (int k = 0; k < Arrow.Count; k++)
            {
                if (Arrow[k].xarrow >= xhero && Arrow[k].xarrow <= xhero + 50)
                {
                    if (Arrow[k].yarrow >= yhero && Arrow[k].yarrow <= yhero + 100)
                    {
                        if (hearts.Count > 0)
                        {
                            hearts.RemoveAt(hearts.Count - 1);
                            Arrow.RemoveAt(k);
                            k--;
                            break;
                        }
                    }
                }
            }
            
            for (int k = 0; k < boll3.Count; k++)
            {
                if (boll3[k].xboulet3 >= xhero && boll3[k].xboulet3 <= xhero + 50)
                {
                    if (boll3[k].yboulet3 >= yhero && boll3[k].yboulet3 <= yhero + 100)
                    {
                        if (hearts.Count > 0)
                        {
                            hearts.RemoveAt(hearts.Count - 1);
                            boll3.RemoveAt(k);
                            k--;
                            break;
                        }
                    }
                }
            }
            for (int k = 0; k < ff.Count; k++)
            {
                if (ff[k].xfire >= xhero && ff[k].xfire <= xhero + 50)
                {
                    if (ff[k].yfire >= yhero && ff[k].yfire <= yhero + 100)
                    {
                        if (hearts.Count > 0)
                        {
                            hearts.RemoveAt(hearts.Count - 1);
                            ff.RemoveAt(k);
                            k--;
                            break;
                        }
                    }
                }
            }


            if (off == 0)
            {
                if (xhero + 100 >= this.Width - 150 && xhero <= this.Width - 50 && yhero + 100 >= elevatorY && flage == 2 && on == 1)
                {
                    isOnElevator = true;
                    heroAttachedToElevator = true;

                }
                else
                {
                    isOnElevator = false;
                }


                if (heroAttachedToElevator == true)
                {
                    elevatorMoving = true;
                }

                if (elevatorMoving == true)
                {
                    elevatorY -= elevatorSpeed;

                    if (heroAttachedToElevator == true)
                    {
                        yhero = elevatorY - 90;
                        heroAttachedToElevator = false;
                    }
                }
            }
            
            if (flagline == 1)
            {
                slinex += 400;
                elinex += 400;
            }
            xplan1 += 15;
            if (flagelevel2 == true)
            {
                xplan2 += 15;
            }
            for (int i = 0; i < boll.Count; i++)
            {
                boulet pnn = boll[i];
                if (flagboll == 1)
                {
                    pnn.xboulet += 50;
                }
            }
            for (int i = 0; i < boll2.Count; i++)
            {
                boulet pnn = boll2[i];
                if (flagboll2 == 1)
                {
                    pnn.xboulet2 += 50;
                }
            }
            if (flage == 1)
            {
                if (counter1 == space)
                {
                    enemy pnn2 = new enemy();

                    pnn2.xenemy1 = this.ClientSize.Width;
                    pnn2.yenemy1 = yhero;


                    n.Add(pnn2);

                    counter1 = 0;
                    if (score == 5)////belal 5555555
                    {
                        space = -1;
                    }///5555555555
                }
                counter1++;
                for (int i = 0; i < n.Count; i++)
                {

                    n[i].xenemy1 -= 25;


                }
            }
            for (int k = 0; k < shots.Count; k++)
            {
                if (shots[k].xs >= xhero && shots[k].xs <= xhero + 100)
                {
                    if (shots[k].ys >= yhero && shots[k].ys <= yhero + 100)
                    {
                        if (hearts.Count > 0)
                        {
                            hearts.RemoveAt(hearts.Count - 1);
                            shots.RemoveAt(k);
                            k--;
                            break;
                        }
                    }
                }
            }
            ////////////////coin 
            for (int i = 0; i < coins.Count; i++)
            {
                if (coins[i].xcoin >= xhero && coins[i].xcoin <=xhero  +40 )
                {
                    if (coins[i].ycoin >=yhero && yhero <=coins[i].ycoin +40)
                    {

                        coins.RemoveAt(i); 
                        if(coins.Count ==0)
                        {
                            flagline = 1;
                        }
                        i--;
                        break;

                    }
                }

            }
            //////////////
            for (int k = 0; k < n.Count; k++)
            {
                if (n[k].xenemy1 >= xhero && n[k].xenemy1 <= xhero + 40)
                {
                    if (n[k].yenemy1 >= yhero && n[k].yenemy1 <= yhero + 40)
                    {
                        if (hearts.Count > 0)
                        {

                            hearts.RemoveAt(hearts.Count - 1);
                            n.RemoveAt(k);
                            k--;
                            break;
                        }
                    }
                }
            }
            for (int k = 0; k < ff1.Count; k++)
            {
                if (ff1[k].xfireboos >= xhero && ff1[k].xfireboos <= xhero + 100)
                {
                    if (ff1[k].yfireboos >= yhero && ff1[k].yfireboos <= yhero + 100)
                    {
                        if (hearts.Count > 0)
                        {

                            hearts.RemoveAt(hearts.Count - 1);
                            ff1.RemoveAt(k);
                            k--;
                            break;
                        }
                    }
                }
            }

            for (int k = 0; k < boll.Count; k++)
            {
                for (int i = 0; i < n.Count; i++)
                {
                    if (boll[k].xboulet > n[i].xenemy1 && boll[k].xboulet < n[i].xenemy1 + 100)
                    {
                        if (boll[k].yboulet > n[i].yenemy1 && boll[k].yboulet < n[i].yenemy1 + 100)
                        {
                            n.RemoveAt(i);
                            boll.RemoveAt(k);
                            score++;
                            k--;
                            i--;
                            break;
                        }
                    }
                }

            }


            for (int k = 0; k < boll2.Count; k++)
            {
                for (int i = 0; i < n.Count; i++)
                {
                    if (boll2[k].xboulet2 > n[i].xenemy1 && boll2[k].xboulet2 < n[i].xenemy1 + 100)
                    {
                        if (boll2[k].yboulet2 > n[i].yenemy1 && boll2[k].yboulet2 < n[i].yenemy1 + 100)
                        {
                            n.RemoveAt(i);
                            boll2.RemoveAt(k);
                            score++;
                            k--;
                            i--;
                            break;
                        }
                    }
                }

            }
            ////////////////enemy2
            for (int k = 0; k < boll.Count; k++)
            {
                for (int i = 0; i < ename.Count; i++)
                {
                    if (boll[k].xboulet > ename[i].xenemy2 && boll[k].xboulet < ename[i].xenemy2 + 100)
                    {
                        if (boll[k].yboulet > ename[i].yenemy2 && boll[k].yboulet < ename[i].yenemy2 + 100)
                        {
                            ename.RemoveAt(i);
                            boll.RemoveAt(k);
                            if (score == 5)////belal555
                            {
                                MessageBox.Show("walk right to go next level");
                                n.Clear();
                            }////5555
                            score++;
                            k--;
                            i--;
                            break;
                        }
                    }
                }

            }
            for (int k = 0; k < boll.Count; k++)
            {
                for (int i = 0; i < ename3.Count; i++)
                {
                    if (boll[k].xboulet > ename3[i].xenemy3 && boll[k].xboulet < ename3[i].xenemy3 + 100)
                    {
                        if (boll[k].yboulet > ename3[i].yenemy3 && boll[k].yboulet < ename3[i].yenemy3 + 100)
                        {
                            ename3.RemoveAt(i);
                            boll.RemoveAt(k);
                            score++;
                            k--;
                            i--;
                            break;
                        }
                    }
                }

            }
            for (int k = 0; k < boll2.Count; k++)
            {
                for (int i = 0; i < ename.Count; i++)
                {
                    if (boll2[k].xboulet2 > ename[i].xenemy2 && boll2[k].xboulet2 < ename[i].xenemy2 + 100)
                    {
                        if (boll2[k].yboulet2 > ename[i].yenemy2 && boll2[k].yboulet2 < ename[i].yenemy2 + 100)
                        {
                            ename.RemoveAt(i);
                            boll2.RemoveAt(k);
                            score++;
                            k--;
                            i--;
                            break;
                        }
                    }
                }

            }
            if (xhero >= this.ClientSize.Width && location == 2)
            {
                flage = 0;
                flagelevel2 = true;
                xhero = 0;
                location = 3;
            }
            if (xplan2 >= this.ClientSize.Width && flagelevel2 == true && ctplan == 0)
            {

                flage = 2;
                ctplan++;
            }
            if (elevatorY < 0 && location == 3)
            {
                flage = 3;
                location = 4;
                flagelevel2 = false;
            }
            if (flage == 3)
            {
                if (countx == 0)
                {
                    xhero = 0;
                    countx++;
                }

                on = 0;
                off = 1;
            }
            DrawDF(this.CreateGraphics());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (flage == 3)
            {
                if (e.KeyCode == Keys.W)
                {
                    wait = true;
                    if (xhero >= xsteps)
                    {

                        yhero -= 50;
                        initialYHero = yhero;
                    }
                }

                if (e.KeyCode == Keys.S)
                {
                    if (xhero >= xsteps )
                    {
                            yhero += 50;
                            initialYHero = yhero;
                        
                    }
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                xhero -= 15;
                part2.x2 -= 4;
                part3.x3 -= 4;
                part4.x4 -= 4;
                if (part2.x2 < 0)
                {
                    part2.x2 = back1.Width / 2;
                }
                else if (part3.x3 < 0)
                {
                    part3.x3 = back2.Width / 2;
                }
                else if (part4.x4 < 0)
                {
                    part4.x4 = back3.Width / 2;
                }
                pos++;
                if (pos == 4)
                {
                    pos = 0;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                xhero += 50;
                part2.x2 += 4;
                part3.x3 += 4;
                part4.x4 += 4;
                if ((part2.x2 + back1.Width / 2) > back1.Width)
                {
                    part2.x2 = 0;
                }
                else if ((part3.x3 + back2.Width / 2) > back2.Width)
                {
                    part3.x3 = 0;
                }
                else if ((part4.x4 + back3.Width / 2) > back3.Width)
                {
                    part4.x4 = 0;
                }

                pos++;
                if (pos == 4)
                {
                    pos = 0;
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                isLeftPressed = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                isRightPressed = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                isSpacePressed = true;
            }
            if (isSpacePressed && e.KeyCode == Keys.Up)
            {
                isJumping = true;
                jumpingBackward = false;
                jumpingForward = false;
            }
            if (isSpacePressed && isRightPressed)
            {
                isJumping = true;
                jumpingForward = true;
                jumpingBackward = false;
            }
            if (isSpacePressed && isLeftPressed)
            {
                isJumping = true;
                jumpingBackward = true;
                jumpingForward = false;
            }

            if (e.KeyCode == Keys.Z)
            {
                int xboulet = xhero + 50;
                int yboulet = yhero + 40;
                boulet pnn = new boulet();
                pnn.xboulet = xboulet;
                pnn.yboulet = yboulet;
                flagboll = 1;
                boll.Add(pnn);
                T.Start();
            }
            if (e.KeyCode == Keys.X)
            {
                int xboulet2 = xhero + 50;
                int yboulet2 = yhero + 40;
                for (int i = 0; i < 3; i++)
                {
                    boulet pnn = new boulet();
                    pnn.xboulet2 = xboulet2;
                    pnn.yboulet2 = yboulet2;
                    flagboll2 = 1;
                    boll2.Add(pnn);
                    xboulet2 += 25;
                }

                T.Start();
            }
            if (e.KeyCode == Keys.L)
            {
                if(flagline==1)
                {
                    slinex = xhero + 50;
                    sliney = yhero + 20;
                    elinex = this.ClientSize.Width;
                    eliney = sliney;

                    T.Start();
                }
      
            }
            DrawDF(this.CreateGraphics());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setValues();
            off_image = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            initialYHero = yhero;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDF(e.Graphics);
        }
        void setValues()
        {
            xenamy1 = this.Width - 200;
            yenamy1 = 50;
            enamy pnn = new enamy();
            pnn.xe = xenamy1;
            pnn.ye = yenamy1;
            plane.Add(pnn);

        

            int xheart = this.ClientSize.Width - 200;
            int yheart = 0;
            for (int i = 0; i < 3; i++)
            {
                heart pnn2 = new heart();
                pnn2.xheart = xheart;
                pnn2.yheart = yheart;
                hearts.Add(pnn2);
                xheart = xheart + 60;
            }
            xrestart = this.ClientSize.Width - 260;
            yrestart = 0;


            int xcoin = xdowncoin + 300;
            int ycoin = ydowncoin;
            for (int i = 0; i < 2; i++)
            {
                coin pnn3 = new coin();

                pnn3.xcoin = xcoin;
                pnn3.ycoin = ycoin;
                coins.Add(pnn3);
                xcoin += 150;
            }


            part2.x2 = 0;
            part3.x3 = 0;
            part4.x4 = 0;
        }
        void Drawscene(Graphics g)
        {
            Pen pen = new Pen(Color.Red, 6);
            if (flage == 1 || flage == 2 || flage == 3)///////5555555
            {
                g.Clear(Color.Black);
            }///////5555
            if (flage == 1)
            {
                g.DrawImage(back1, new Rectangle(0, 0, this.Width, this.Height),
               new Rectangle(part2.x2, 0, back1.Width / 2, back1.Height), GraphicsUnit.Pixel);
            }
            if (flagelevel2 == true)
            {
                g.DrawImage(back2, new Rectangle(0, 0, this.Width, this.Height),
                new Rectangle(part3.x3, 0, back2.Width / 2, back2.Height), GraphicsUnit.Pixel);
                g.DrawImage(level2, xplan2, yplan2, 400, 100);
            }

            if (flage == 2)
            {
                n.Clear();///////belal 5555555

                if (score < 8)
                {
                    for (int i = 0; i < ename.Count; i++)
                    {
                        g.DrawImage(enamy2[pos2], ename[i].xenemy2, ename[i].yenemy2, 100, 100);
                    }
                    for (int i = 0; i < plane.Count; i++)
                    {
                        g.DrawImage(enamy1[side], plane[i].xe, plane[i].ye, 150, 150);
                    }
                    for (int i = 0; i < shots.Count; i++)
                    {
                        g.DrawImage(polit[0], shots[i].xs, shots[i].ys, 70, 70);
                    }
                    
                    for (int i = 0; i < Arrow.Count; i++)
                    {
                        g.DrawImage(arroow[0], Arrow[i].xarrow, Arrow[i].yarrow, 100, 60);
                    }
                }
                else
                {
                    g.DrawImage(elvetor[0], this.Width - 150, elevatorY, 100, 30);
                }
                for (int i = 0; i < hearts.Count; i++)
                {
                    g.DrawImage(h, hearts[i].xheart, hearts[i].yheart, 50, 50);
                }
                for (int i = 0; i < boll2.Count; i++)
                {
                    if (flagboll2 == 1)
                    {
                        g.DrawImage(boulet1, boll2[i].xboulet2 + 30, boll2[i].yboulet2, 25, 25);
                    }
                }
                g.DrawImage(Restart, xrestart, yrestart, 50, 50);
            }
            if (flage == 3)
            {
                g.DrawImage(back3, new Rectangle(0, 0, this.Width, this.Height),
                new Rectangle(part4.x4, 0, back3.Width / 2, back3.Height), GraphicsUnit.Pixel);
                g.DrawImage(level3, xplan3, yplan3, 400, 100);

                for (int i = 0; i < hearts.Count; i++)
                {
                    g.DrawImage(h, hearts[i].xheart, hearts[i].yheart, 50, 50);
                }
               
                
                g.DrawImage(Restart, xrestart, yrestart, 50, 50);
                g.DrawImage(steps, xsteps, ysteps, wsteps, hsteps);
                g.DrawImage(down, xdowncoin + 250, ydowncoin + 30, 300, 50);
                for (int i = 0; i < coins.Count; i++)
                {
                    g.DrawImage(c[poscoin], coins[i].xcoin, coins[i].ycoin, 40, 40);
                }

                if (flagline == 1)
                {
                    g.DrawLine(pen, slinex, sliney, elinex, eliney);
                }
                
                for (int i = 0; i < ff.Count; i++)
                {
                    g.DrawImage(fireball, ff[i].xfire, ff[i].yfire, 100, 150);
                }
                if (score < 12)
                {
                    for (int i = 0; i < ename3.Count; i++)
                    {
                        g.DrawImage(enamy3[pos3], ename3[i].xenemy3, ename3[i].yenemy3, 100, 100);
                    }
                    for (int i = 0; i < boll3.Count; i++)
                    {
                        g.DrawImage(boulet2, boll3[i].xboulet3 + 30, boll3[i].yboulet3, 25, 25);
                    }
                }
                else
                {
                    flage_final_level = 1;
                }
                if (flage_final_level == 1)
                {
                    if (flagline == 1)
                    {
                        g.DrawImage(hh2[poshealth], xhealth, yhealth, whealth, hhealth);

                    }
                    for (int i = 0; i < Boss.Count; i++)
                    {
                        g.DrawImage(po, Boss[i].xboss, Boss[i].yboss, 300, 300);
                    }
                    for (int i = 0; i < ff1.Count; i++)
                    {
                        g.DrawImage(fireboos, ff1[i].xfireboos, ff1[i].yfireboos, 80, 80);
                    }
                    g.DrawImage(Queen, xqueen, yqueen, 200, 200);
                   
                }
                if (flagwin==1)
                {
                    g.DrawImage(win, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
                }
            }
            if (flage == 1)
            {
                for (int i = 0; i < hearts.Count; i++)
                {
                    g.DrawImage(h, hearts[i].xheart, hearts[i].yheart, 50, 50);
                }
                g.DrawImage(level1, xplan1, yplan1, 400, 100);
                for (int i = 0; i < n.Count; i++)
                {
                    g.DrawImage(enemy1, n[i].xenemy1, n[i].yenemy1, 100, 100);
                }
                g.DrawImage(Restart, xrestart, yrestart, 50, 50);
            }
            if (flage == 1 || flage == 2 || flage == 3)///////5555555
            {
                if (flagdie == 1)////5555
                {
                    poshero.Clear();
                    if (diepos == 3)
                    {
                        flagdie = 2;

                        diepos--;
                        flage = 4;
                    }
                    g.DrawImage(dieh[diepos], xhero, yhero, 100, 70);
                }///555
            }///////5555


            for (int i = 0; i < boll.Count; i++)
            {
                if (flagboll == 1)
                {
                    g.DrawImage(boulet1, boll[i].xboulet + 30, boll[i].yboulet, 25, 25);
                }
            }

            if (flagdie == 2)////belal 55555
            {

                g.DrawImage(gameover, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
            }////// 55555555
            if (flagdie == 0&& flagwin==0)////5555
            {
                g.DrawImage(poshero[pos], xhero, yhero, 100, 100);

            }/////555555


            if (flage == 1 || flage == 2 || flage == 3&&flagwin==0)///////5555555
            {
                string scoreText = "Score: " + score.ToString();
                Font font = new Font("Arial", 20);
                Brush brush = Brushes.Red;
                g.DrawString(scoreText, font, brush, 10, 20);
            }///////5555
        }
        void DrawDF(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off_image);
            Drawscene(g2);
            g.DrawImage(off_image, 0, 0);
        }
    }
    class actor
    {
        public int x2;
        public int x3;
        public int x4;
    }
    public class enamy
    {
        public int xe;
        public int ye;
        public bool isMovingRight = false;
        
    }
    public class Shot
    {
        public int xs;
        public int ys;
    }
    public class enamy2
    {
        public int xenemy2;
        public int yenemy2;
    }
    public class enamy3
    {
        public int xenemy3;
        public int yenemy3;
    }
    class boulet
    {
        public int xboulet;
        public int yboulet;

        public int xboulet2;
        public int yboulet2;

        public int xboulet3;
        public int yboulet3;

    }
    class enemy 
    {
        public int xenemy1;
        public int yenemy1;
    }
    public class arrow
    {
        public int xarrow;
        public int yarrow;
    }
    public class heart
    {
        public int xheart;
        public int yheart;
    }
    public class coin
    {
        public int xcoin;
        public int ycoin;
    }
    public class health
    {
        public int xhealth;
        public int yhealth;
        public int whealth;
        public int hhealth;

    }
    public class fire
    {
        public int xfire;
        public int yfire;
    }
    public class fireboos
    {
        public int xfireboos;
        public int yfireboos;
    }
    public class boss
    {
        public int xboss;
        public int yboss;
    }
    public class diehero///belal 55555
    {
        public int xdie;
        public int ydie;
        public int wdie;
        public int hdie;

    }/////555
}