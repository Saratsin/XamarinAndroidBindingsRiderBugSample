package sample.androidlibrary;

import androidx.annotation.IntDef;

import java.lang.annotation.Documented;
import java.lang.annotation.Retention;
import java.lang.annotation.RetentionPolicy;

public abstract class StateProvider {

    @Documented
    @Retention(RetentionPolicy.SOURCE)
    @IntDef({STATE_ON, STATE_OFF, STATE_SUPERPOSITION, STATE_UNKNOWN})
    @interface State {}

    public static final int STATE_ON = 1 << 1;

    public static final int STATE_OFF = 1 << 2;

    public static final int STATE_SUPERPOSITION = STATE_ON | STATE_OFF;

    public static final int STATE_UNKNOWN = 1 << 3;

    public abstract @State int getState();

    public abstract void setState(@State int state);
}
