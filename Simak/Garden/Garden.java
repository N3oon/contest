package Garden;

import java.util.Random;

public class Garden{
        Random random=new Random();
    Plant[][] pole = new Plant[10][10];
    Plant randPosiv(int k)
    { Plant p=null;
        switch (k){
            case 0:
               p=new Tomato();
                break;
            case 1:
                p=new Potato();
                break;
            case 2:
                p=new Tabacco();
                break;
            case 3:
                p=new Weed();
                break;
            case 4:
                p=new Null();
                break;
        }
        return p;
    }
//   void plant(int x, int y, Plant p)
//{
//    pole[x][y]=p;
//       }
  void print() {

      for (int i=0;i<pole.length;i++) {
          for (int j=0;j<pole.length;j++) {
              int k=random.nextInt(5);
              Plant p=randPosiv(k);
              pole[i][j]=p;
              System.out.print(p.getSymbol()+"\t");
          }
          System.out.println();
      }
  }
}
