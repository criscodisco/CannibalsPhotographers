package com.cannibal_photographer;



import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.ImageView;

public class Boat extends ImageView {
	
	
	boolean state = true;
	
	
	public Boat(Context context) {
        super(context);
        init();
	}
	
	 public Boat(Context context, AttributeSet attrs)
	    {
	        super(context, attrs);
	        init();
	    }

	 public Boat(Context context, AttributeSet attrs, int defStyle)
	    {
	        super(context, attrs, defStyle);
	        init();
	    }

	
    private void init()
    {
        this.setOnClickListener(new OnClickListener() {
            @Override
            public void onClick (View v) {
                if (state) {
				    moveBoatForward(-290);
                } else {
                    moveBoatReverse(290);
                }
			}
        });
    }
    
   

	public void moveBoatForward(int amount){
        this.offsetTopAndBottom(amount);
        state = !state;
	}
	
    public void moveBoatReverse(int amount) {
        this.offsetTopAndBottom(amount);
        state = !state;
	}

}



