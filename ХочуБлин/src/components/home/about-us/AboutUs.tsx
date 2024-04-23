import { memo, useRef } from 'react'
import styles from './about-us.module.css'
import useViewOnScroll from 'src/hooks/useViewOnScroll'

const AboutUs = () => {
    const title_ref = useRef(null)
    const text_ref = useRef(null)
    const line_ref = useRef(null)
    const [title_view] = useViewOnScroll(title_ref)
    const [text_view] = useViewOnScroll(text_ref)
    const [line_view] = useViewOnScroll(line_ref)
    return (
        <div className={styles.wrapper}>
            <div className={styles.content_wrapper}>
                <div className={styles.description}>
                    <h1 ref={title_ref} className={`${styles.title} ${title_view && styles.active}`}>
                        О нас
                    </h1>

                    <div ref={text_ref} className={`${styles.text} ${text_view && styles.active}`}>
                        <p className={styles.top_text}>Мы очень хорошие ходите к нам у нас вкусно и хорошо очень ждем приходите к нам с друзьями мы всем очень очень рады идеальное место для первого свидания и для второго и для третьего и для четвертого</p>
                        <p className={styles.bottom_text}>
                            в наших <a href="/link">социальных сетях</a> вы можете узнать больше о нас, поделиться впечатлениями или предложениями
                        </p>
                    </div>
                </div>
                <div className={styles.poster_wrapper}>
                    <img className={styles.poster} src="/woman.png" alt="" />
                    <div ref={line_ref} className={`${styles.anim_line} ${line_view && styles.line_active}`}></div>
                </div>
            </div>
        </div>
    )
}
export default memo(AboutUs)
