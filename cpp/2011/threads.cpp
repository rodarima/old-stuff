  #include <process.h>

  #include <stdio.h>

  
  int a[ 5 ];
  
  void Thread( void* pParams )
  { int i, num = 0;
  
    while ( 1 )
    { 
       for ( i = 0; i < 5; i++ ) a[ i ] = num;
       num++;
    }
  }
  
  int main( void )
  { 
     _beginthread( Thread, 0, NULL );
  
     while( a[0]<100000 )
        printf("%d %d %d %d %d\n", 
               a[ 0 ], a[ 1 ], a[ 2 ],
               a[ 3 ], a[ 4 ] );
  
   return 0;
   
  }
