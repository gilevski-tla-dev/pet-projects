import { memo, useRef } from 'react'
import useViewOnScroll from 'src/hooks/useViewOnScroll'
import styles from './poster.module.css'

const Poster = () => {
    const ref = useRef(null)
    const [view] = useViewOnScroll(ref)

    return (
        <div className={styles.wrapper}>
            <div className={styles.poster_wrapper}>
                <div className={styles.grey_bg}></div>
                <img src="/new_poster.png" className={styles.poster} />
                <div className={styles.gradient}></div>
                <h1 ref={ref} className={`${styles.title} ${view && styles.active}`}>
                    Хочу Блин
                </h1>
            </div>
        </div>
    )
}

export default memo(Poster)
