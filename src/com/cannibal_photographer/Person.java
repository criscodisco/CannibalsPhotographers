package com.cannibal_photographer;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.ImageView;

public class Person extends ImageView {
	
	boolean state = true;
	
	public Person(Context context) {
        super(context);
        init();
	}
	
	 public Person(Context context, AttributeSet attrs)
	    {
	        super(context, attrs);
	        init();
	    }

	 public Person(Context context, AttributeSet attrs, int defStyle)
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
				    movePerson(325,-230);
                } else {
                    movePerson(-325,230);
                }
			}
        });
        
	
    }
    
    public void movePerson(int x, int y)
    {
    	this.offsetLeftAndRight(x);
    	this.offsetTopAndBottom(y);
    	
    	state = !state;
    }

}
