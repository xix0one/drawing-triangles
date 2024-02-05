/*

#
##
###
####
#####
######
#######
########
#########
##########

##########
#########
########
#######
######
#####
####
###
##
#

         #
        ##
       ###
      ####
     #####
    ######
   #######
  ########
 #########
##########

##########
 #########
  ########
   #######
    ######
     #####
      ####
       ###
        ##
         # 

 */

public class Program
{
    public static void Main()
    {

        for (int i = 1; i < 11; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write('#');
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 10; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write('#');
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 10; i > 0; i--)
        {
            for (int j = 1; j < i; j++)
            {
                Console.Write(' ');
            }
            for (int k = 11; k > i; k--)
            {
                Console.Write('#');
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 0; i < 10; i++)
        {
            for (int k = 0; k < i; k++)
            {
                Console.Write(' ');
            }
            for (int j = 10; j > i; j--)
            {
                Console.Write('#');
            }
            Console.WriteLine();
        }
    }
}