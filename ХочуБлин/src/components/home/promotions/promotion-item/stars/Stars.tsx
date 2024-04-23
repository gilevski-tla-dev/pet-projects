import { FC } from 'react'
import Star from 'src/components/ui/Star'
import styles from './stars.module.css'

const Stars: FC<{ color: string }> = ({ color }) => {
    return (
        <>
            <div className={`${styles.star_wrapper} ${styles.star_1}`}>
                <Star stroke={color} />
            </div>
            <div className={`${styles.star_wrapper} ${styles.star_2}`}>
                <Star stroke={color} />
            </div>
            <div className={`${styles.star_wrapper} ${styles.star_3}`}>
                <Star stroke={color} />
            </div>
            <div className={`${styles.star_wrapper} ${styles.star_4}`}>
                <Star stroke={color} />
            </div>
            <div className={`${styles.star_wrapper} ${styles.star_5}`}>
                <Star stroke={color} />
            </div>
        </>
    )
}
export default Stars
