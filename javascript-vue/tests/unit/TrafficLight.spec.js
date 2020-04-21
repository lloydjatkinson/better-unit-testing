import { mount } from '@vue/test-utils';
import TrafficLight from '../../src/components/TrafficLight';

describe('TrafficLight.vue', () => {
    let wrapper;

    beforeEach(() => {
        wrapper = mount(TrafficLight);
    });

    it('should be off initially', () => {
        expect(wrapper.vm.redOn).toBe(false);
        expect(wrapper.vm.yellowOn).toBe(false);
        expect(wrapper.vm.greenOn).toBe(false);
    });

    it('should transition to red from off', () => {
        wrapper.vm.nextState();

        expect(wrapper.vm.redOn).toBe(true);
    });

    it('should transition to red yellow from red', () => {
        wrapper.vm.nextState();
        wrapper.vm.nextState();

        expect(wrapper.vm.redOn).toBe(true);
        expect(wrapper.vm.yellowOn).toBe(true);
    });

    it('should transition to off when off button is clicked', () => {
        wrapper.vm.nextState();
        wrapper.vm.nextState();
        wrapper.vm.nextState();

        wrapper.find('[data-off]').trigger('click');

        expect(wrapper.vm.redOn).toBe(false);
        expect(wrapper.vm.yellowOn).toBe(false);
        expect(wrapper.vm.greenOn).toBe(false);
    });
});